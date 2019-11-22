using Newtonsoft.Json.Linq;
using RESTaccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3Csharp
{
    public partial class Form1 : Form
    {
        private RESTapi rest = null;
        Stopwatch sw = new Stopwatch();
        List<string> facultyNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
            Populate();
        }

        public void Populate()
        {
            rest = new RESTapi("http://ist.rit.edu/api");
            // Get About information
            string jsonAbout = rest.getRESTData("/about/");

            Console.WriteLine(jsonAbout);

            // Convert the JSON to an About C# object
            // use http://json2csharp.com
            // enter http://ist.rit.edu/api/about 

            About about = JToken.Parse(jsonAbout).ToObject<About>();

            lbl_aboutTitle.Text = about.title;

            richTextBox1.Text = about.description;

            lbl_about_quoteAuthor.Text = about.quoteAuthor;

            textBox1.Text = about.quote;

            // Get /resources/ 
            string jsonRes = rest.getRESTData("/resources/");

            // Create Resources object to load the parsed JSON
            Resources resources = 
                JToken.Parse(jsonRes).ToObject<Resources>();

            // Add the link text to the display
            lnkLbl_http.Text =
                resources.tutorsAndLabInformation.tutoringLabHoursLink;

        } // Populate()
/*
        #region Common method getRESTData( url ) used throughout this code
        public string getRESTData(string url)
        {
            const string baseUri = "http://ist.rit.edu/api";

            // connect to the api
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUri + url);

            try
            {
                // waits and gets the response for this web request
                WebResponse response = request.GetResponse();

                // using the response stream from the web request, read it
                using (Stream responseStream = response.GetResponseStream())
                {
                    // read the response from the API
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }

            }
            catch(WebException we)
            {
                WebResponse err = we.Response;
                using(Stream responseStream = err.GetResponseStream())
                {
                    StreamReader r = new StreamReader(responseStream, Encoding.UTF8);
                    string errorText = r.ReadToEnd();
                    // do something like log this error to an error log file
                    // or cheap out with this error message
                    Console.WriteLine("ERROR: "+errorText);
                }
                // Can't do anything more, throw this exception... the easy way
                throw;
            }

        } // getRESTData

        #endregion
*/
        private void LnkLbl_http_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(lnkLbl_http.Text);
            lnkLbl_http.LinkVisited = true;
        }

        private void Btn_people_Click(object sender, EventArgs e)
        {
            // Load the People information
            string jsonPeople = rest.getRESTData("/people/");

            // cast to a people object
            People people = JToken.Parse(jsonPeople).ToObject<People>();

            // loop through JSON array of faculty
            foreach( Faculty thisfac in people.faculty)
            {
                Console.WriteLine(thisfac.name);
                pictureBox_People.Load(thisfac.imagePath);
                comboBoxFaculty.Items.Add(thisfac.name);
                facultyNames.Add(thisfac.username);
            }

            GetSingleInstance("mjfics", people);
        }

        private void GetSingleInstance(string id, People people)
        {
            // Find the person's Id
            // UGLY and time consuming way 
            foreach(Faculty thisFac in people.faculty)
            {
                if(thisFac.username == id)
                {
                    Console.WriteLine("\nInstance: " + thisFac.name);
                }
            }

            // Better way, lambda
            Faculty result = people.faculty.Find(x => x.username == id);
            Console.WriteLine("Lambda: "+result.name);

            // Getting many, lambda style
            List<Faculty> bigResult =
                people.faculty.FindAll(x => x.title == "Lecturer");
            foreach(Faculty aFac in bigResult)
            {
                Console.WriteLine("Lecturers: "+aFac.name);
            }

        } // end GetSingleInstance


        private void Form1_Load(object sender, EventArgs e)
        {
            // dynamically add a tab
            string title = "News";
            TabPage newstabpage = new TabPage(title);
            tabControl1.TabPages.Insert(2, newstabpage);

            TextBox tb = new TextBox();
            tb.BackColor = SystemColors.Info;
            tb.Location = new Point(50, 10);
            tb.Size = new Size(200, 30);
            tb.TabIndex = 1;
            tb.Text = "Enter your name...";

            // add the news text box to the News tab page
            newstabpage.Controls.Add(tb);

        }

        private void Btn_people_Enter(object sender, EventArgs e)
        {
            
            Btn_people_Click(null, null);
        }

        private void btn_loaddata_Click(object sender, EventArgs e)
        {
            string jsonEmp = rest.getRESTData("/employment/");

            Employment employment =
                JToken.Parse(jsonEmp).ToObject<Employment>();

            sw.Reset();
            sw.Start();

            for (int i=0; i<employment.coopTable.coopInformation.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value =
                    employment.coopTable.coopInformation[i].employer;
                dataGridView1.Rows[i].Cells[1].Value =
                    employment.coopTable.coopInformation[i].degree;
                dataGridView1.Rows[i].Cells[2].Value =
                    employment.coopTable.coopInformation[i].city;
                dataGridView1.Rows[i].Cells[3].Value =
                    employment.coopTable.coopInformation[i].term;

            }


            sw.Stop();
            Console.WriteLine("Data: "+sw.ElapsedMilliseconds.ToString());

        } // btn_loaddata

        private void tabCoop_Enter(object sender, EventArgs e)
        {
            // create the columns for ListView
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            // add column headers and widths
            listView1.Width = 450;
            listView1.Columns.Add("Employer", 100);
            listView1.Columns.Add("Degree", 100);
            listView1.Columns.Add("City", 100);
            listView1.Columns.Add("Term", 100);

        } // tabCoop_Enter

        private void btn_loadlist_Click(object sender, EventArgs e)
        {
            string jsonEmp = rest.getRESTData("/employment/");
            Employment employment =
                JToken.Parse(jsonEmp).ToObject<Employment>();

            sw.Reset();
            sw.Start();


            // Populate the List View
            ListViewItem item;

            for(int i=0; i<employment.coopTable.coopInformation.Count; i++)
            {
                // build the row to display
                item = new ListViewItem(
                    new String[]
                    {
                        employment.coopTable.coopInformation[i].employer,
                        employment.coopTable.coopInformation[i].degree,
                        employment.coopTable.coopInformation[i].city,
                        employment.coopTable.coopInformation[i].term
                    }
                );

                // Append this list item to the row
                listView1.Items.Add(item);

            } // for

            sw.Stop();
            Console.WriteLine( "List: "+sw.ElapsedMilliseconds.ToString() );


        }

        private void TabContact_Enter(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("http://ist.rit.edu/api/contactForm.php");
        }

        private void BtnEmploymentMap_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://ist.rit.edu/api/map.php");
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get what got us here
            ComboBox comboBox = (ComboBox)sender;

            // save the selected employee's name, to lookup the index in the combobox list
            // to get the username from the other list.
            string selectedEmployee = (string)comboBoxFaculty.SelectedItem;

            int resultIndex = -1;   // where in list is this person. let it error if not found

            // find the first instance of the selected employee
            resultIndex = comboBoxFaculty.FindStringExact(selectedEmployee);

            string jsonPeople = rest.getRESTData(
                "/people/faculty/username=" + facultyNames[resultIndex]);

            Console.WriteLine(jsonPeople);

            Faculty onefac = JToken.Parse(jsonPeople).ToObject<Faculty>();

            lbl_People1.Text = selectedEmployee;
            lbl_People2.Text = "Index: " + resultIndex.ToString();
            lbl_People3.Text = onefac.email;

        }
    } // end Form1
        
}
