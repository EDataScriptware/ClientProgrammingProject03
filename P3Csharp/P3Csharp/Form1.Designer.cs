namespace P3Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.lnkLbl_http = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_about_quoteAuthor = new System.Windows.Forms.Label();
            this.lbl_const_quote = new System.Windows.Forms.Label();
            this.lbl_aboutTitle = new System.Windows.Forms.Label();
            this.tabPeople = new System.Windows.Forms.TabPage();
            this.pictureBox_People = new System.Windows.Forms.PictureBox();
            this.btn_people = new System.Windows.Forms.Button();
            this.tabDegrees = new System.Windows.Forms.TabPage();
            this.tabResources = new System.Windows.Forms.TabPage();
            this.tabCoop = new System.Windows.Forms.TabPage();
            this.btnEmploymentMap = new System.Windows.Forms.Button();
            this.btn_loadlist = new System.Windows.Forms.Button();
            this.btn_loaddata = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dvEmployers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvDegrees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbl_People3 = new System.Windows.Forms.Label();
            this.lbl_People2 = new System.Windows.Forms.Label();
            this.lbl_People1 = new System.Windows.Forms.Label();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.tabPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_People)).BeginInit();
            this.tabCoop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabContact.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Controls.Add(this.tabPeople);
            this.tabControl1.Controls.Add(this.tabDegrees);
            this.tabControl1.Controls.Add(this.tabResources);
            this.tabControl1.Controls.Add(this.tabCoop);
            this.tabControl1.Controls.Add(this.tabContact);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1214, 927);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAbout
            // 
            this.tabAbout.BackColor = System.Drawing.Color.PeachPuff;
            this.tabAbout.Controls.Add(this.lnkLbl_http);
            this.tabAbout.Controls.Add(this.textBox1);
            this.tabAbout.Controls.Add(this.richTextBox1);
            this.tabAbout.Controls.Add(this.lbl_about_quoteAuthor);
            this.tabAbout.Controls.Add(this.lbl_const_quote);
            this.tabAbout.Controls.Add(this.lbl_aboutTitle);
            this.tabAbout.Location = new System.Drawing.Point(8, 39);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAbout.Size = new System.Drawing.Size(1198, 880);
            this.tabAbout.TabIndex = 0;
            this.tabAbout.Text = "About";
            // 
            // lnkLbl_http
            // 
            this.lnkLbl_http.AutoSize = true;
            this.lnkLbl_http.Location = new System.Drawing.Point(230, 462);
            this.lnkLbl_http.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLbl_http.Name = "lnkLbl_http";
            this.lnkLbl_http.Size = new System.Drawing.Size(110, 25);
            this.lnkLbl_http.TabIndex = 13;
            this.lnkLbl_http.TabStop = true;
            this.lnkLbl_http.Text = "linkLabel1";
            this.lnkLbl_http.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkLbl_http_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(158, 263);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(638, 144);
            this.textBox1.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(158, 38);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(638, 164);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // lbl_about_quoteAuthor
            // 
            this.lbl_about_quoteAuthor.AutoSize = true;
            this.lbl_about_quoteAuthor.Location = new System.Drawing.Point(90, 412);
            this.lbl_about_quoteAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_about_quoteAuthor.Name = "lbl_about_quoteAuthor";
            this.lbl_about_quoteAuthor.Size = new System.Drawing.Size(70, 25);
            this.lbl_about_quoteAuthor.TabIndex = 10;
            this.lbl_about_quoteAuthor.Text = "label3";
            // 
            // lbl_const_quote
            // 
            this.lbl_const_quote.AutoSize = true;
            this.lbl_const_quote.Location = new System.Drawing.Point(104, 223);
            this.lbl_const_quote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_const_quote.Name = "lbl_const_quote";
            this.lbl_const_quote.Size = new System.Drawing.Size(76, 25);
            this.lbl_const_quote.TabIndex = 9;
            this.lbl_const_quote.Text = "Quote:";
            // 
            // lbl_aboutTitle
            // 
            this.lbl_aboutTitle.AutoSize = true;
            this.lbl_aboutTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aboutTitle.ForeColor = System.Drawing.Color.Red;
            this.lbl_aboutTitle.Location = new System.Drawing.Point(86, 0);
            this.lbl_aboutTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_aboutTitle.Name = "lbl_aboutTitle";
            this.lbl_aboutTitle.Size = new System.Drawing.Size(203, 45);
            this.lbl_aboutTitle.TabIndex = 8;
            this.lbl_aboutTitle.Text = "about title";
            // 
            // tabPeople
            // 
            this.tabPeople.Controls.Add(this.pictureBox_People);
            this.tabPeople.Controls.Add(this.btn_people);
            this.tabPeople.Location = new System.Drawing.Point(8, 39);
            this.tabPeople.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPeople.Name = "tabPeople";
            this.tabPeople.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPeople.Size = new System.Drawing.Size(1198, 880);
            this.tabPeople.TabIndex = 1;
            this.tabPeople.Text = "People";
            this.tabPeople.UseVisualStyleBackColor = true;
            this.tabPeople.Enter += new System.EventHandler(this.Btn_people_Enter);
            // 
            // pictureBox_People
            // 
            this.pictureBox_People.Location = new System.Drawing.Point(234, 42);
            this.pictureBox_People.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_People.Name = "pictureBox_People";
            this.pictureBox_People.Size = new System.Drawing.Size(139, 105);
            this.pictureBox_People.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_People.TabIndex = 17;
            this.pictureBox_People.TabStop = false;
            // 
            // btn_people
            // 
            this.btn_people.Location = new System.Drawing.Point(72, 106);
            this.btn_people.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_people.Name = "btn_people";
            this.btn_people.Size = new System.Drawing.Size(134, 69);
            this.btn_people.TabIndex = 16;
            this.btn_people.Text = "Get People";
            this.btn_people.UseVisualStyleBackColor = true;
            this.btn_people.Click += new System.EventHandler(this.Btn_people_Click);
            this.btn_people.Enter += new System.EventHandler(this.Btn_people_Enter);
            // 
            // tabDegrees
            // 
            this.tabDegrees.Location = new System.Drawing.Point(8, 39);
            this.tabDegrees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDegrees.Name = "tabDegrees";
            this.tabDegrees.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabDegrees.Size = new System.Drawing.Size(1198, 880);
            this.tabDegrees.TabIndex = 2;
            this.tabDegrees.Text = "Degrees";
            this.tabDegrees.UseVisualStyleBackColor = true;
            // 
            // tabResources
            // 
            this.tabResources.Location = new System.Drawing.Point(8, 39);
            this.tabResources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabResources.Name = "tabResources";
            this.tabResources.Size = new System.Drawing.Size(1198, 880);
            this.tabResources.TabIndex = 3;
            this.tabResources.Text = "Resources";
            this.tabResources.UseVisualStyleBackColor = true;
            // 
            // tabCoop
            // 
            this.tabCoop.Controls.Add(this.btnEmploymentMap);
            this.tabCoop.Controls.Add(this.btn_loadlist);
            this.tabCoop.Controls.Add(this.btn_loaddata);
            this.tabCoop.Controls.Add(this.listView1);
            this.tabCoop.Controls.Add(this.dataGridView1);
            this.tabCoop.Location = new System.Drawing.Point(8, 39);
            this.tabCoop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCoop.Name = "tabCoop";
            this.tabCoop.Size = new System.Drawing.Size(1198, 880);
            this.tabCoop.TabIndex = 4;
            this.tabCoop.Text = "Coop";
            this.tabCoop.UseVisualStyleBackColor = true;
            this.tabCoop.Enter += new System.EventHandler(this.tabCoop_Enter);
            // 
            // btnEmploymentMap
            // 
            this.btnEmploymentMap.Location = new System.Drawing.Point(38, 379);
            this.btnEmploymentMap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEmploymentMap.Name = "btnEmploymentMap";
            this.btnEmploymentMap.Size = new System.Drawing.Size(150, 117);
            this.btnEmploymentMap.TabIndex = 4;
            this.btnEmploymentMap.Text = "Show employment map";
            this.btnEmploymentMap.UseVisualStyleBackColor = true;
            this.btnEmploymentMap.Click += new System.EventHandler(this.BtnEmploymentMap_Click);
            // 
            // btn_loadlist
            // 
            this.btn_loadlist.Location = new System.Drawing.Point(38, 583);
            this.btn_loadlist.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_loadlist.Name = "btn_loadlist";
            this.btn_loadlist.Size = new System.Drawing.Size(150, 117);
            this.btn_loadlist.TabIndex = 3;
            this.btn_loadlist.Text = "Load List View";
            this.btn_loadlist.UseVisualStyleBackColor = true;
            this.btn_loadlist.Click += new System.EventHandler(this.btn_loadlist_Click);
            // 
            // btn_loaddata
            // 
            this.btn_loaddata.Location = new System.Drawing.Point(38, 144);
            this.btn_loaddata.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_loaddata.Name = "btn_loaddata";
            this.btn_loaddata.Size = new System.Drawing.Size(150, 117);
            this.btn_loaddata.TabIndex = 2;
            this.btn_loaddata.Text = "Load Data View";
            this.btn_loaddata.UseVisualStyleBackColor = true;
            this.btn_loaddata.Click += new System.EventHandler(this.btn_loaddata_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(248, 463);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(920, 392);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvEmployers,
            this.dvDegrees,
            this.dvCity,
            this.dvTerm});
            this.dataGridView1.Location = new System.Drawing.Point(248, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(924, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // dvEmployers
            // 
            this.dvEmployers.HeaderText = "Employers";
            this.dvEmployers.MinimumWidth = 10;
            this.dvEmployers.Name = "dvEmployers";
            this.dvEmployers.Width = 200;
            // 
            // dvDegrees
            // 
            this.dvDegrees.HeaderText = "Degrees";
            this.dvDegrees.MinimumWidth = 10;
            this.dvDegrees.Name = "dvDegrees";
            this.dvDegrees.Width = 200;
            // 
            // dvCity
            // 
            this.dvCity.HeaderText = "City";
            this.dvCity.MinimumWidth = 10;
            this.dvCity.Name = "dvCity";
            this.dvCity.Width = 200;
            // 
            // dvTerm
            // 
            this.dvTerm.HeaderText = "Term";
            this.dvTerm.MinimumWidth = 10;
            this.dvTerm.Name = "dvTerm";
            this.dvTerm.Width = 200;
            // 
            // tabContact
            // 
            this.tabContact.Controls.Add(this.webBrowser1);
            this.tabContact.Location = new System.Drawing.Point(8, 39);
            this.tabContact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabContact.Name = "tabContact";
            this.tabContact.Size = new System.Drawing.Size(1198, 880);
            this.tabContact.TabIndex = 5;
            this.tabContact.Text = "Contact";
            this.tabContact.UseVisualStyleBackColor = true;
            this.tabContact.Enter += new System.EventHandler(this.TabContact_Enter);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(40, 38);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1198, 880);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbl_People3);
            this.tabPage3.Controls.Add(this.lbl_People2);
            this.tabPage3.Controls.Add(this.lbl_People1);
            this.tabPage3.Controls.Add(this.comboBoxFaculty);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1198, 880);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "Select Person";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // lbl_People3
            // 
            this.lbl_People3.AutoSize = true;
            this.lbl_People3.Location = new System.Drawing.Point(432, 288);
            this.lbl_People3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_People3.Name = "lbl_People3";
            this.lbl_People3.Size = new System.Drawing.Size(70, 25);
            this.lbl_People3.TabIndex = 3;
            this.lbl_People3.Text = "label3";
            // 
            // lbl_People2
            // 
            this.lbl_People2.AutoSize = true;
            this.lbl_People2.Location = new System.Drawing.Point(432, 185);
            this.lbl_People2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_People2.Name = "lbl_People2";
            this.lbl_People2.Size = new System.Drawing.Size(70, 25);
            this.lbl_People2.TabIndex = 2;
            this.lbl_People2.Text = "label2";
            // 
            // lbl_People1
            // 
            this.lbl_People1.AutoSize = true;
            this.lbl_People1.Location = new System.Drawing.Point(432, 81);
            this.lbl_People1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_People1.Name = "lbl_People1";
            this.lbl_People1.Size = new System.Drawing.Size(70, 25);
            this.lbl_People1.TabIndex = 1;
            this.lbl_People1.Text = "label1";
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(62, 81);
            this.comboBoxFaculty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(238, 33);
            this.comboBoxFaculty.TabIndex = 0;
            this.comboBoxFaculty.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFaculty_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1254, 963);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "C# consumes ist.rit.edu/api";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.tabPeople.ResumeLayout(false);
            this.tabPeople.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_People)).EndInit();
            this.tabCoop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabContact.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.LinkLabel lnkLbl_http;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_about_quoteAuthor;
        private System.Windows.Forms.Label lbl_const_quote;
        private System.Windows.Forms.Label lbl_aboutTitle;
        private System.Windows.Forms.TabPage tabPeople;
        private System.Windows.Forms.TabPage tabDegrees;
        private System.Windows.Forms.TabPage tabResources;
        private System.Windows.Forms.TabPage tabCoop;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox_People;
        private System.Windows.Forms.Button btn_people;
        private System.Windows.Forms.Button btn_loadlist;
        private System.Windows.Forms.Button btn_loaddata;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvEmployers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvDegrees;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvTerm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnEmploymentMap;
        private System.Windows.Forms.Label lbl_People3;
        private System.Windows.Forms.Label lbl_People2;
        private System.Windows.Forms.Label lbl_People1;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
    }
}

