namespace Project3_RileyE
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
            this.tabDegrees = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutUsTab = new System.Windows.Forms.TabPage();
            this.txtboxAboutUsDesc = new System.Windows.Forms.RichTextBox();
            this.txtboxAboutUs = new System.Windows.Forms.RichTextBox();
            this.lblAboutUsTitle = new System.Windows.Forms.Label();
            this.degreesTab = new System.Windows.Forms.TabPage();
            this.degreesConcentrationListView = new System.Windows.Forms.ListView();
            this.concentrationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtboxDegreesDesc = new System.Windows.Forms.RichTextBox();
            this.lblDegreesTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.computingAndInformationTechnologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanCompuingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webAndMobileComputingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graduateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationSciencesTechnologiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanComputerInteractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkingAndSystemsAdministrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minorsTab = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.employmentTab = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabDegrees.SuspendLayout();
            this.homeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aboutUsTab.SuspendLayout();
            this.degreesTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.minorsTab.SuspendLayout();
            this.employmentTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDegrees
            // 
            this.tabDegrees.Controls.Add(this.homeTab);
            this.tabDegrees.Controls.Add(this.aboutUsTab);
            this.tabDegrees.Controls.Add(this.degreesTab);
            this.tabDegrees.Controls.Add(this.minorsTab);
            this.tabDegrees.Controls.Add(this.employmentTab);
            this.tabDegrees.Location = new System.Drawing.Point(-1, 2);
            this.tabDegrees.Name = "tabDegrees";
            this.tabDegrees.SelectedIndex = 0;
            this.tabDegrees.Size = new System.Drawing.Size(847, 426);
            this.tabDegrees.TabIndex = 0;
            this.tabDegrees.Enter += new System.EventHandler(this.tbControl_Enter);
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.label4);
            this.homeTab.Controls.Add(this.label3);
            this.homeTab.Controls.Add(this.pictureBox1);
            this.homeTab.Controls.Add(this.label2);
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Location = new System.Drawing.Point(4, 22);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(839, 400);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(346, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edward Riley";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(268, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Please select on a tab above to proceed! ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project3_RileyE.Properties.Resources.rit_logo;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(295, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 210);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(308, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Window Forms Edition!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(227, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Golisano Home Page!";
            // 
            // aboutUsTab
            // 
            this.aboutUsTab.Controls.Add(this.txtboxAboutUsDesc);
            this.aboutUsTab.Controls.Add(this.txtboxAboutUs);
            this.aboutUsTab.Controls.Add(this.lblAboutUsTitle);
            this.aboutUsTab.Location = new System.Drawing.Point(4, 22);
            this.aboutUsTab.Name = "aboutUsTab";
            this.aboutUsTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutUsTab.Size = new System.Drawing.Size(839, 400);
            this.aboutUsTab.TabIndex = 1;
            this.aboutUsTab.Text = "About Us";
            this.aboutUsTab.UseVisualStyleBackColor = true;
            // 
            // txtboxAboutUsDesc
            // 
            this.txtboxAboutUsDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxAboutUsDesc.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAboutUsDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.txtboxAboutUsDesc.Location = new System.Drawing.Point(23, 48);
            this.txtboxAboutUsDesc.Name = "txtboxAboutUsDesc";
            this.txtboxAboutUsDesc.Size = new System.Drawing.Size(519, 120);
            this.txtboxAboutUsDesc.TabIndex = 2;
            this.txtboxAboutUsDesc.Text = "About Us Desc";
            // 
            // txtboxAboutUs
            // 
            this.txtboxAboutUs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxAboutUs.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtboxAboutUs.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.txtboxAboutUs.Location = new System.Drawing.Point(23, 174);
            this.txtboxAboutUs.Name = "txtboxAboutUs";
            this.txtboxAboutUs.Size = new System.Drawing.Size(449, 141);
            this.txtboxAboutUs.TabIndex = 1;
            this.txtboxAboutUs.Text = "About Us Quotes";
            // 
            // lblAboutUsTitle
            // 
            this.lblAboutUsTitle.AutoSize = true;
            this.lblAboutUsTitle.Font = new System.Drawing.Font("Minion Pro", 18F, System.Drawing.FontStyle.Bold);
            this.lblAboutUsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.lblAboutUsTitle.Location = new System.Drawing.Point(3, 3);
            this.lblAboutUsTitle.Name = "lblAboutUsTitle";
            this.lblAboutUsTitle.Size = new System.Drawing.Size(226, 32);
            this.lblAboutUsTitle.TabIndex = 0;
            this.lblAboutUsTitle.Text = "About Us Title Label";
            // 
            // degreesTab
            // 
            this.degreesTab.Controls.Add(this.degreesConcentrationListView);
            this.degreesTab.Controls.Add(this.txtboxDegreesDesc);
            this.degreesTab.Controls.Add(this.lblDegreesTitle);
            this.degreesTab.Controls.Add(this.menuStrip1);
            this.degreesTab.Location = new System.Drawing.Point(4, 22);
            this.degreesTab.Name = "degreesTab";
            this.degreesTab.Size = new System.Drawing.Size(839, 400);
            this.degreesTab.TabIndex = 2;
            this.degreesTab.Text = "Degrees";
            this.degreesTab.UseVisualStyleBackColor = true;
            // 
            // degreesConcentrationListView
            // 
            this.degreesConcentrationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.concentrationHeader});
            this.degreesConcentrationListView.HideSelection = false;
            this.degreesConcentrationListView.LabelWrap = false;
            this.degreesConcentrationListView.Location = new System.Drawing.Point(301, 58);
            this.degreesConcentrationListView.Name = "degreesConcentrationListView";
            this.degreesConcentrationListView.Size = new System.Drawing.Size(120, 240);
            this.degreesConcentrationListView.TabIndex = 3;
            this.degreesConcentrationListView.UseCompatibleStateImageBehavior = false;
            // 
            // txtboxDegreesDesc
            // 
            this.txtboxDegreesDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDegreesDesc.Location = new System.Drawing.Point(36, 126);
            this.txtboxDegreesDesc.Name = "txtboxDegreesDesc";
            this.txtboxDegreesDesc.Size = new System.Drawing.Size(252, 96);
            this.txtboxDegreesDesc.TabIndex = 2;
            this.txtboxDegreesDesc.Text = "Degrees Desc Label";
            // 
            // lblDegreesTitle
            // 
            this.lblDegreesTitle.AutoSize = true;
            this.lblDegreesTitle.Location = new System.Drawing.Point(33, 58);
            this.lblDegreesTitle.Name = "lblDegreesTitle";
            this.lblDegreesTitle.Size = new System.Drawing.Size(99, 13);
            this.lblDegreesTitle.TabIndex = 1;
            this.lblDegreesTitle.Text = "Degrees Title Label";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.graduateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.computingAndInformationTechnologyToolStripMenuItem,
            this.humanCompuingToolStripMenuItem,
            this.webAndMobileComputingToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.testToolStripMenuItem.Text = "Undergraduate";
            // 
            // computingAndInformationTechnologyToolStripMenuItem
            // 
            this.computingAndInformationTechnologyToolStripMenuItem.Name = "computingAndInformationTechnologyToolStripMenuItem";
            this.computingAndInformationTechnologyToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.computingAndInformationTechnologyToolStripMenuItem.Text = "Computing and Information Technology";
            this.computingAndInformationTechnologyToolStripMenuItem.Click += new System.EventHandler(this.computingAndInformationTechnologyToolStripMenuItem_Click);
            // 
            // humanCompuingToolStripMenuItem
            // 
            this.humanCompuingToolStripMenuItem.Name = "humanCompuingToolStripMenuItem";
            this.humanCompuingToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.humanCompuingToolStripMenuItem.Text = "Human Centered Computing";
            this.humanCompuingToolStripMenuItem.Click += new System.EventHandler(this.humanCompuingToolStripMenuItem_Click);
            // 
            // webAndMobileComputingToolStripMenuItem
            // 
            this.webAndMobileComputingToolStripMenuItem.Name = "webAndMobileComputingToolStripMenuItem";
            this.webAndMobileComputingToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.webAndMobileComputingToolStripMenuItem.Text = "Web and Mobile Computing";
            this.webAndMobileComputingToolStripMenuItem.Click += new System.EventHandler(this.webAndMobileComputingToolStripMenuItem_Click);
            // 
            // graduateToolStripMenuItem
            // 
            this.graduateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationSciencesTechnologiesToolStripMenuItem,
            this.humanComputerInteractionToolStripMenuItem,
            this.networkingAndSystemsAdministrationToolStripMenuItem});
            this.graduateToolStripMenuItem.Name = "graduateToolStripMenuItem";
            this.graduateToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.graduateToolStripMenuItem.Text = "Graduate";
            // 
            // informationSciencesTechnologiesToolStripMenuItem
            // 
            this.informationSciencesTechnologiesToolStripMenuItem.Name = "informationSciencesTechnologiesToolStripMenuItem";
            this.informationSciencesTechnologiesToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.informationSciencesTechnologiesToolStripMenuItem.Text = "Information Sciences and Technologies";
            // 
            // humanComputerInteractionToolStripMenuItem
            // 
            this.humanComputerInteractionToolStripMenuItem.Name = "humanComputerInteractionToolStripMenuItem";
            this.humanComputerInteractionToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.humanComputerInteractionToolStripMenuItem.Text = "Human Computer Interaction";
            // 
            // networkingAndSystemsAdministrationToolStripMenuItem
            // 
            this.networkingAndSystemsAdministrationToolStripMenuItem.Name = "networkingAndSystemsAdministrationToolStripMenuItem";
            this.networkingAndSystemsAdministrationToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.networkingAndSystemsAdministrationToolStripMenuItem.Text = "Networking and Systems Administration";
            // 
            // minorsTab
            // 
            this.minorsTab.Controls.Add(this.label6);
            this.minorsTab.Controls.Add(this.listBox2);
            this.minorsTab.Controls.Add(this.richTextBox1);
            this.minorsTab.Controls.Add(this.label5);
            this.minorsTab.Controls.Add(this.listBox1);
            this.minorsTab.Location = new System.Drawing.Point(4, 22);
            this.minorsTab.Name = "minorsTab";
            this.minorsTab.Size = new System.Drawing.Size(839, 400);
            this.minorsTab.TabIndex = 3;
            this.minorsTab.Text = "Minors";
            this.minorsTab.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Location = new System.Drawing.Point(212, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 227);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Undergraduate Minors Desc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Undergraduate Minors Title";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Undergraduate Minors Name"});
            this.listBox1.Location = new System.Drawing.Point(29, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 275);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Undergraduate Minor Courses"});
            this.listBox2.Location = new System.Drawing.Point(563, 69);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 260);
            this.listBox2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Courses";
            // 
            // employmentTab
            // 
            this.employmentTab.Controls.Add(this.listView1);
            this.employmentTab.Controls.Add(this.richTextBox2);
            this.employmentTab.Controls.Add(this.label7);
            this.employmentTab.Location = new System.Drawing.Point(4, 22);
            this.employmentTab.Name = "employmentTab";
            this.employmentTab.Size = new System.Drawing.Size(839, 400);
            this.employmentTab.TabIndex = 4;
            this.employmentTab.Text = "Employment";
            this.employmentTab.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employment Intro Main Title";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(13, 42);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(380, 332);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Employment Content Title and Desc";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(427, 42);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(380, 332);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(845, 428);
            this.Controls.Add(this.tabDegrees);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Edward Riley - Golisano Home Page";
            this.tabDegrees.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aboutUsTab.ResumeLayout(false);
            this.aboutUsTab.PerformLayout();
            this.degreesTab.ResumeLayout(false);
            this.degreesTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.minorsTab.ResumeLayout(false);
            this.minorsTab.PerformLayout();
            this.employmentTab.ResumeLayout(false);
            this.employmentTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDegrees;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage aboutUsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAboutUsTitle;
        private System.Windows.Forms.RichTextBox txtboxAboutUs;
        private System.Windows.Forms.RichTextBox txtboxAboutUsDesc;
        private System.Windows.Forms.TabPage degreesTab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graduateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem computingAndInformationTechnologyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanCompuingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webAndMobileComputingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationSciencesTechnologiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanComputerInteractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkingAndSystemsAdministrationToolStripMenuItem;
        private System.Windows.Forms.Label lblDegreesTitle;
        private System.Windows.Forms.RichTextBox txtboxDegreesDesc;
        private System.Windows.Forms.ListView degreesConcentrationListView;
        private System.Windows.Forms.ColumnHeader concentrationHeader;
        private System.Windows.Forms.TabPage minorsTab;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage employmentTab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ListView listView1;
    }
}

