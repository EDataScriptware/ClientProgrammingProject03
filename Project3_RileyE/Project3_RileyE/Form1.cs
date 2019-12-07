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



    public partial class MainWindow : Form
    {
        private RESTapi baseRestURL = null;

        public MainWindow()
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
            Research();
            Resources();



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
            lblEmploymentTitleDesc.Text = employment.employers.title + ": ";
            // Console.WriteLine(employment.employers.employerNames.Count());
            try
            {
                for (int i = 0; i < employment.employers.employerNames.Count(); i++)
                {
                    // Console.WriteLine(i+1);

                    if (employment.employers.employerNames.Count() == (i + 1))
                    {
                        // Console.WriteLine("Stopping at: " + i + " " + employment.employers.employerNames[i] + " ");
                        lblEmploymentTitleDesc.Text += employment.employers.employerNames[i];
                    }
                    else
                    {
                        lblEmploymentTitleDesc.Text += employment.employers.employerNames[i] + ", ";
                    }
                }
            }
            catch (Exception)
            {

            }

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

            lblPeopleFacultyMainTitle.Text = people.title;
            lblPeopleStaffMainTitle.Text = people.title;
            lblPeopleFacultySubtitle.Text = people.subTitle;
            lblPeopleStaffSubtitle.Text = people.subTitle;

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

            try
            {
                for (int i = 0; i < people.staff.Count(); i++)
                {
                    cbPeopleStaff.Items.Add(people.staff[i].name);

                }
            }
            catch (Exception)
            {

            }
            // sets first choice to 0 so it is not automatically empty at first
            cbPeopleFacultyNames.SelectedIndex = 0;
            cbPeopleStaff.SelectedIndex = 0;

        }

        private void cbPeopleFacultyNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbPeopleFacultyNames.SelectedIndex;
            pbPeopleFacultyPic.ImageLocation = people.faculty[index].imagePath;
            lblPeopleFacultyTitle.Text = people.faculty[index].title;
            lblPeopleFacultyOffice.Text = "Office: " + people.faculty[index].office;
            lblPeopleFacultyEmail.Text = "Email: " + people.faculty[index].email;
            lblPeopleFacultyPhone.Text = "Phone: " + people.faculty[index].phone;
            lblPeopleFacultyUsername.Text = "Username: " + (people.faculty[index].username).ToUpper();

            lblLinkPeopleWebsite.Text = people.faculty[index].website;


        }

        private void cbPeopleStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbPeopleStaff.SelectedIndex;
            pictureBoxPeopleStaff.ImageLocation = people.staff[index].imagePath;
            lblPeopleStaffTitle.Text = people.staff[index].title;
            lblPeopleStaffOffice.Text = "Office: " + people.staff[index].office;
            lblPeopleStaffEmail.Text = "Email: " + people.staff[index].email;
            lblPeopleStaffPhone.Text = "Phone: " + people.staff[index].phone;
            lblPeopleStaffUsername.Text = "Username: " + (people.staff[index].username).ToUpper();

            linkLblPeopleStaffWebsite.Text = people.staff[index].website;
        }

        // click and directs on a default web browser to faculty's website
        private void lblLinkPeopleWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int index = cbPeopleFacultyNames.SelectedIndex;

            System.Diagnostics.Process.Start(people.faculty[index].website);
        }
        #endregion

        #region Research
        Research research = null;

        private void Research()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonResearch = baseRestURL.getRESTData("/research/");
            research = JToken.Parse(jsonResearch).ToObject<Research>();
            // Console.WriteLine(jsonResearch);

            try
            {
                for (int i = 0; i < research.byInterestArea.Count(); i++)
                {
                    listboxResearchByInterestArea.Items.Add(research.byInterestArea[i].areaName);
                }
            }
            catch (Exception)
            {

            }

            try
            {
                for (int i = 0; i < research.byFaculty.Count(); i++)
                {
                    listboxResearchByFaculty.Items.Add(research.byFaculty[i].facultyName +
                        " (" + research.byFaculty[i].username + ")");
                }
            }
            catch (Exception)
            {

            }

        }



        private void listboxResearchByInterestArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listboxResearchByInterestArea.SelectedIndex;
            richTextBoxResearchByInterestCitation.Text = "";
            try
            {
                for (int i = 0; i < research.byInterestArea[index].citations.Count(); i++)
                {
                    richTextBoxResearchByInterestCitation.Text += "- " +
                          research.byInterestArea[index].citations[i] + "\n\n";
                }
            }
            catch (Exception)
            {

            }
        }



        private void listboxResearchByFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listboxResearchByFaculty.SelectedIndex;
            richTextBoxResearchByFacultyCitation.Text = "";
            try
            {
                for (int i = 0; i < research.byFaculty[index].citations.Count(); i++)
                {
                    richTextBoxResearchByFacultyCitation.Text += "- " +
                        research.byFaculty[index].citations[i] + "\n\n";
                }
            }
            catch (Exception)
            {

            }
        }
        #endregion

        #region Resources
        Resources resources = null;

        private void Resources()
        {
            baseRestURL = new RESTapi("http://ist.rit.edu/api");
            string jsonResources = baseRestURL.getRESTData("/resources/");
            resources = JToken.Parse(jsonResources).ToObject<Resources>();
            // Console.WriteLine(jsonResources);

            lblStudentResourcesTitle.Text = resources.title;
            lblStudentResourcesSubtitle.Text = resources.subTitle;

            lblResourcesStudyAbroad.Text = resources.studyAbroad.title;

            richTextBoxResourcesStudyAbroadDesc.Text = resources.studyAbroad.description;
            try
            {
                for (int i = 0; i < resources.studyAbroad.places.Count(); i++)
                {
                    richTextBoxResourcesStudyAbroadDesc.Text += "\n\n- " +
                           resources.studyAbroad.places[i].nameOfPlace + "\n\t" +
                           resources.studyAbroad.places[i].description;
                }
            }
            catch (Exception)
            {

            }

            lblResourcesTutorTitle.Text = resources.tutorsAndLabInformation.title;
            richTextBoxResourcesTutorDesc.Text = resources.tutorsAndLabInformation.description;

            lblResourcesAdvisingAcademicTitle.Text = resources.studentServices.academicAdvisors.title;
            richtextboxAcademicAdvisorDesc.Text = resources.studentServices.academicAdvisors.description;
            linkLblAcademicAdvisor.Text = resources.studentServices.academicAdvisors.faq.title;

            lblResourcesAdvisingFacultyTitle.Text = resources.studentServices.facultyAdvisors.title;
            richtextboxFacultyAdvisorDesc.Text = resources.studentServices.facultyAdvisors.description;
            // Academic Advisors

            try
            {
                for (int i = 0; i < resources.studentServices.professonalAdvisors.advisorInformation.Count(); i++)
                {
                    datagridviewResourcesAcademicAdvisor.Rows.Add(
                        resources.studentServices.professonalAdvisors.advisorInformation[i].name,             // name
                        resources.studentServices.professonalAdvisors.advisorInformation[i].department,       // department
                        resources.studentServices.professonalAdvisors.advisorInformation[i].email             // email
                        );

                }
            }
            catch (Exception)
            {

            }

            try
            {
                for (int i = 0; i < resources.studentServices.istMinorAdvising.minorAdvisorInformation.Count(); i++)
                {
                    datagridviewResourcesISTAdvisor.Rows.Add(
                        resources.studentServices.istMinorAdvising.minorAdvisorInformation[i].advisor,          // name of advisor
                        resources.studentServices.istMinorAdvising.minorAdvisorInformation[i].title,            // title (department)
                        resources.studentServices.istMinorAdvising.minorAdvisorInformation[i].email             // email
                        );

                }
            }
            catch (Exception)
            {

            }


            lblResourcesAmbassadorsTitle.Text = resources.studentAmbassadors.title;
            pictureBoxResourcesAmbassadorsPic.ImageLocation = resources.studentAmbassadors.ambassadorsImageSource;

            try
            {
                for (int i = 0; i < (resources.studentAmbassadors.subSectionContent.Count() - 1); i++)
                {

                    richTextBoxAmbassadorsContent.Text +=
                        resources.studentAmbassadors.subSectionContent[i].title + "\n";
                    richTextBoxAmbassadorsContent.Text += "- " +
                        resources.studentAmbassadors.subSectionContent[i].description
                        + "\n\n";

                }

            }
            catch (Exception)
            {

            }

            lblResourcesAmbassadorsApplyDesc.Text = resources.studentAmbassadors.subSectionContent[6].description;
            linkLabelAmbassadorsUrl.Text = resources.studentAmbassadors.subSectionContent[6].title.ToUpper();
            lblResourcesAmbassadorNote.Text = resources.studentAmbassadors.note;


            lblResourcesAcademicCoopInfoTitle.Text = resources.coopEnrollment.title;
            try
            {
                for (int i = 0; i < resources.coopEnrollment.enrollmentInformationContent.Count(); i++)
                {
                    richTextBoxResourcesAcademicCoopInfoDesc.Text +=
                        resources.coopEnrollment.enrollmentInformationContent[i].title + "\n";
                    richTextBoxResourcesAcademicCoopInfoDesc.Text +=
                        resources.coopEnrollment.enrollmentInformationContent[i].description + "\n\n";

                }
            }
            catch (Exception)
            {

            }


            linkLblResourcesGradOne.Text = resources.forms.graduateForms[0].formName;
            linkLblResourcesGradTwo.Text = resources.forms.graduateForms[1].formName;
            linkLblResourcesGradThree.Text = resources.forms.graduateForms[2].formName;
            linkLblResourcesGradFour.Text = resources.forms.graduateForms[3].formName;
            linkLblResourcesGradFive.Text = resources.forms.graduateForms[4].formName;
            linkLblResourcesGradSix.Text = resources.forms.graduateForms[5].formName;
            linkLblResourcesGradSeven.Text = resources.forms.graduateForms[6].formName;

            linkLblResourcesUnderOne.Text = resources.forms.undergraduateForms[0].formName;


        }
        private void linkLblResourcesTutorSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesTutorSchedule.LinkVisited = true;

            System.Diagnostics.Process.Start(resources.tutorsAndLabInformation.tutoringLabHoursLink);
        }

        private void linkLblAcademicAdvisor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblAcademicAdvisor.LinkVisited = true;

            System.Diagnostics.Process.Start(resources.studentServices.academicAdvisors.faq.contentHref);

        }

        private void linkLabelAmbassadorsUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelAmbassadorsUrl.LinkVisited = true;

            System.Diagnostics.Process.Start(resources.studentAmbassadors.applicationFormLink);

        }

        private void linkLblAcademicCoopInfoUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblAcademicCoopInfoUrl.LinkVisited = true;

            System.Diagnostics.Process.Start(resources.coopEnrollment.RITJobZoneGuidelink);
        }

        private void linkLblResourcesGradOne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesGradOne.LinkVisited = true;
            try
            { 
                System.Diagnostics.Process.Start(resources.forms.graduateForms[0].href);
            }
            catch (Exception)
            {
                Console.WriteLine("Online file not found");
            }
        }

        private void linkLblResourcesGradTwo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesGradTwo.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(resources.forms.graduateForms[1].href);
            }
            catch (Exception)
            {
                Console.WriteLine("Online file not found");
            }
        }

        private void linkLblResourcesGradThree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesGradThree.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(resources.forms.graduateForms[2].href);
            }
            catch (Exception)
            {
                Console.WriteLine("Online file not found");
            }
        }

        private void linkLblResourcesGradFour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesGradFour.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(resources.forms.graduateForms[3].href);
            }
            catch (Exception)
            {
                Console.WriteLine("Online file not found");
            }
        }

        private void linkLblResourcesGradFive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesGradFive.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(resources.forms.graduateForms[4].href);
            }
            catch (Exception)
            {
                Console.WriteLine("Online file not found");
            }
        }

        private void linkLblResourcesGradSix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesGradSix.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(resources.forms.graduateForms[5].href);
            }
            catch (Exception)
            {
                Console.WriteLine("Online file not found");
            }
        }

        private void linkLblResourcesUnderOne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLblResourcesUnderOne.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start(resources.forms.undergraduateForms[0].href);
            }
            catch (Exception)
            {
                Console.WriteLine("Online file not found");
            }
        }
    }
    #endregion








}

