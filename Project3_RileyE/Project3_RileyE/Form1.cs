using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTaccess;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Project3_RileyE
{
    // http://json2csharp.com/ - to be used when changing json stuff to csharp accessors and mutatotrs
    // Example will be used with http://ist.rit.edu/api/about 



    public partial class Form1 : Form
    {
        private RESTapi baseRestURL = null;

        public Form1()
        {
            InitializeComponent();

            // music functionality - THE Legend of Zelda: Breath of the Wild "Cooking SFX" - 
            // By Manaka Kataoka, Yasuaki Iwata, Hajime Wakai | owned by Nintendo (C) (tm)

            System.Media.SoundPlayer music = new System.Media.SoundPlayer(@"../../media/opening.wav");
            music.Play();

            // methods to load
            AboutUs();
            Degrees();




        }

        #region AboutUs
        // About Us Tab
        private void AboutUs()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");


            string jsonAbout = baseRestURL.getRESTData("/about/");

            // Console.WriteLine(jsonAbout);

            AboutUs about = JToken.Parse(jsonAbout).ToObject<AboutUs>();

            lblAboutUsTitle.Text = about.title;
            txtboxAboutUs.Text = '"' + about.quote + '"';
            txtboxAboutUs.Text += " - " + about.quoteAuthor;
            txtboxAboutUsDesc.Text = about.description;
        }
        #endregion

        #region Degrees
        Degrees degrees = null;
        Undergraduate undergraduate = null;


        private void Degrees()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonDegrees = baseRestURL.getRESTData("/degrees/");

            degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();
            Console.WriteLine(jsonDegrees);



        }

        // Computing and Information Technology
        private void computingAndInformationTechnologyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonUndergraduate = baseRestURL.getRESTData("/degrees/undergraduate/");

            undergraduate = JToken.Parse(jsonUndergraduate).ToObject<Undergraduate>();

            lblDegreesTitle.Text = (degrees.undergraduate[2].title);
            lblDegreesTitle.Text += " (" + (degrees.undergraduate[2].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.undergraduate[2].description);
            
            for (int i = 0; i < degrees.undergraduate[2].concentrations[i].Count(); i++)
            {
                Console.WriteLine(i);
            }
                       
                        

        }

        // Human Center Computing
        private void humanCompuingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.undergraduate[1].title);
            lblDegreesTitle.Text += " (" + (degrees.undergraduate[1].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.undergraduate[1].description);

        }

        private void webAndMobileComputingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.undergraduate[0].title);
            lblDegreesTitle.Text += " (" + (degrees.undergraduate[0].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.undergraduate[0].description);

        }
        #endregion

        private void tbControl_Enter(object sender, EventArgs e)
        {
            // create the columns for ListView
            degreesConcentrationListView.View = View.Details;
            degreesConcentrationListView.GridLines = true;
            degreesConcentrationListView.FullRowSelect = true;

            // add column headers and widths
            degreesConcentrationListView.Columns.RemoveAt(0);
            degreesConcentrationListView.Columns.Add("Concentrations", 100);



        }
    }
}
