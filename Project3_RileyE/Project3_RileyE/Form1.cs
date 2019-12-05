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

            // System.Media.SoundPlayer music = new System.Media.SoundPlayer(@"../../media/opening.wav");
            // music.Play();

            // methods to load
            AboutUs();
            Degrees();
            Minors();
            Employment();
            People();




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

        private void Degrees()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonDegrees = baseRestURL.getRESTData("/degrees/");

            degrees = JToken.Parse(jsonDegrees).ToObject<Degrees>();
            // Console.WriteLine(jsonDegrees);

            lblDegreesTitle.Text = "";
            txtboxDegreesDesc.Text = "";



        }

        // Computing and Information Technology
        private void computingAndInformationTechnologyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lblDegreesTitle.Text = (degrees.undergraduate[2].title);
            lblDegreesTitle.Text += " (" + (degrees.undergraduate[2].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.undergraduate[2].description);
            degreesConcentrationListView.Items.Clear();

            try
            {
                for (int i = 0; i < degrees.undergraduate[2].concentrations[i].Count(); i++)
                {
                    // Console.WriteLine(degrees.undergraduate[2].concentrations[i]);
                    degreesConcentrationListView.Items.Add(degrees.undergraduate[2].concentrations[i]);
                }
            }
            catch (Exception)
            {

            }




        }

        // Human Center Computing
        private void humanCompuingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.undergraduate[1].title);
            lblDegreesTitle.Text += " (" + (degrees.undergraduate[1].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.undergraduate[1].description);

            degreesConcentrationListView.Items.Clear();

            try
            {
                for (int i = 0; i < degrees.undergraduate[1].concentrations[i].Count(); i++)
                {
                    // Console.WriteLine(degrees.undergraduate[2].concentrations[i]);
                    degreesConcentrationListView.Items.Add(degrees.undergraduate[1].concentrations[i]);
                }
            }
            catch (Exception)
            {

            }

        }

        private void webAndMobileComputingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.undergraduate[0].title);
            lblDegreesTitle.Text += " (" + (degrees.undergraduate[0].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.undergraduate[0].description);
            degreesConcentrationListView.Items.Clear();
            try
            {
                for (int i = 0; i < degrees.undergraduate[0].concentrations[i].Count(); i++)
                {
                    // Console.WriteLine(degrees.undergraduate[2].concentrations[i]);
                    degreesConcentrationListView.Items.Add(degrees.undergraduate[0].concentrations[i]);
                }
            }
            catch (Exception)
            {

            }

        }

        private void informationSciencesTechnologiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.graduate[0].title);
            lblDegreesTitle.Text += " (" + (degrees.graduate[0].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.graduate[0].description);
            degreesConcentrationListView.Items.Clear();
            try
            {
                for (int i = 0; i < degrees.graduate[0].concentrations[i].Count(); i++)
                {
                    // Console.WriteLine(degrees.undergraduate[2].concentrations[i]);
                    degreesConcentrationListView.Items.Add(degrees.graduate[0].concentrations[i]);
                }
            }
            catch (Exception)
            {

            }


        }

        private void humanComputerInteractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.graduate[1].title);
            lblDegreesTitle.Text += " (" + (degrees.graduate[1].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.graduate[1].description);
            degreesConcentrationListView.Items.Clear();
            try
            {
                for (int i = 0; i < degrees.graduate[1].concentrations[i].Count(); i++)
                {
                    // Console.WriteLine(degrees.undergraduate[2].concentrations[i]);
                    degreesConcentrationListView.Items.Add(degrees.graduate[1].concentrations[i]);
                }
            }
            catch (Exception)
            {

            }
        }

        private void networkingAndSystemsAdministrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.graduate[2].title);
            lblDegreesTitle.Text += " (" + (degrees.graduate[2].degreeName).ToUpper() + ")";

            txtboxDegreesDesc.Text = (degrees.graduate[2].description);
            degreesConcentrationListView.Items.Clear();
            try
            {
                for (int i = 0; i < degrees.graduate[2].concentrations[i].Count(); i++)
                {
                    // Console.WriteLine(degrees.undergraduate[2].concentrations[i]);
                    degreesConcentrationListView.Items.Add(degrees.graduate[1].concentrations[i]);
                }
            }
            catch (Exception)
            {

            }
        }

        private void graduateAdvancedCertficiatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDegreesTitle.Text = (degrees.graduate[3].degreeName.ToUpper());

            txtboxDegreesDesc.Text = "";
            degreesConcentrationListView.Items.Clear();
            try
            {
                for (int i = 0; i < degrees.graduate[3].availableCertificates[i].Count(); i++)
                {
                    // Console.WriteLine(degrees.undergraduate[2].concentrations[i]);
                    degreesConcentrationListView.Items.Add(degrees.graduate[3].availableCertificates[i]);
                }
            }
            catch (Exception)
            {

            }
        }

        private void tbControl_Enter(object sender, EventArgs e)
        {
            // create the columns for ListView
            degreesConcentrationListView.View = View.Details;
            degreesConcentrationListView.GridLines = true;
            degreesConcentrationListView.FullRowSelect = true;

            // add column headers and widths
            degreesConcentrationListView.Columns.RemoveAt(0);

            degreesConcentrationListView.Columns.Add("Concentrations", 399);


        }





        #endregion // endregion degrees

        #region Minors
        Minors minors = null;

        private void Minors()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonMinors = baseRestURL.getRESTData("/minors/");

            minors = JToken.Parse(jsonMinors).ToObject<Minors>();
            // Console.WriteLine(jsonMinors);

            listBoxUgMinorsName.Items.Clear();

            try
            {
                for (int i = 0; i < minors.UgMinors.Count(); i++)
                {
                    listBoxUgMinorsName.Items.Add(minors.UgMinors[i].name);
                }
            }
            catch (Exception)
            {

            }

            lblUgMinorsTitle.Text = "";
            txtboxUgMinorsTitle.Text = "";
            txtBoxUgNote.Text = "";

        }

        private void listBoxUgMinorsName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxUgMinorsName.SelectedIndex;

            lblUgMinorsTitle.Text = minors.UgMinors[index].title;
            txtboxUgMinorsTitle.Text = minors.UgMinors[index].description;


            if (minors.UgMinors[index].note == "")
            {
                txtBoxUgNote.Text = "";
            }
            else
            {
                txtBoxUgNote.Text = "Note: " + minors.UgMinors[index].note;
            }

            listBoxUgMinorsCourses.Items.Clear();

            for (int i = 0; i < minors.UgMinors[index].courses.Count(); i++)
            {
                listBoxUgMinorsCourses.Items.Add("- " + minors.UgMinors[index].courses[i]);
            }

        }
        #endregion

        #region Employment
        Employment employment = null;
        private void Employment()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonEmployment = baseRestURL.getRESTData("/employment/");
            employment = JToken.Parse(jsonEmployment).ToObject<Employment>();

            lblEmpIntroTitle.Text = employment.introduction.title;
            txtBoxContentTitleAndDesc.Text = "";

            // Introduction Title and Desc
            try
            {
                for (int i = 0; i < employment.introduction.content.Count(); i++)
                {
                    txtBoxContentTitleAndDesc.Text += employment.introduction.content[i].title + "\n";
                    txtBoxContentTitleAndDesc.Text += employment.introduction.content[i].description + "\n\n";

                }
            }
            catch (Exception)
            {

            }

            // CoopTable
            try
            {
                for (int i = 0; i < employment.coopTable.coopInformation.Count(); i++)
                {
                    dataGridViewCoopTable.Rows.Add(
                        employment.coopTable.coopInformation[i].employer,   // employer
                        employment.coopTable.coopInformation[i].degree,     // degree
                        employment.coopTable.coopInformation[i].city,       // city
                        employment.coopTable.coopInformation[i].term        // term
                        );

                }
            }
            catch (Exception)
            {

            }
            // sorting CoopTable A-Z 
            dataGridViewCoopTable.Sort(dataGridViewCoopTable.Columns["Employer"], ListSortDirection.Ascending);
        }
            #endregion

        #region People
            
            People people = null;

        private void People()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonPeople = baseRestURL.getRESTData("/people/");
            people = JToken.Parse(jsonPeople).ToObject<People>();

            try
            {
                for (int i = 0; i < people.faculty.Count(); i++)
                {
                    cbPeopleFacultyNames.Items.Add(people.faculty[i].name);

                }
            }
            catch (Exception)
            {
                
            }
            // sets first choice to 0 so it is not automatically empty at first
            cbPeopleFacultyNames.SelectedIndex = 0;
           
        }


        #endregion

        private void cbPeopleFacultyNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbPeopleFacultyNames.SelectedIndex;
            pbPeoplePic.ImageLocation = people.faculty[index].imagePath;
            lblPeopleTitle.Text = people.faculty[index].title;
            lblPeopleOffice.Text = "Office: " + people.faculty[index].office;
            lblPeopleEmail.Text = "Email: " + people.faculty[index].email;
            lblPeoplePhone.Text = "Phone: " + people.faculty[index].phone;
            lblPeopleUsername.Text = "Username: " + (people.faculty[index].username).ToUpper();
            
            lblLinkPeopleWebsite.Text = people.faculty[index].website;


        }


        // click and directs on a default web browser to faculty's website
        private void lblLinkPeopleWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int index = cbPeopleFacultyNames.SelectedIndex;

            System.Diagnostics.Process.Start(people.faculty[index].website);
        }
    }
}
