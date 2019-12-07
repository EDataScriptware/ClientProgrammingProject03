namespace Project3_RileyE
{
    partial class dlgBreakingNews
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
            this.txtBoxBreakingNewsDesc = new System.Windows.Forms.RichTextBox();
            this.txtBoxBreakingNewsTitle = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtBoxBreakingNewsDesc
            // 
            this.txtBoxBreakingNewsDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.txtBoxBreakingNewsDesc.Location = new System.Drawing.Point(15, 46);
            this.txtBoxBreakingNewsDesc.Name = "txtBoxBreakingNewsDesc";
            this.txtBoxBreakingNewsDesc.Size = new System.Drawing.Size(392, 195);
            this.txtBoxBreakingNewsDesc.TabIndex = 6;
            this.txtBoxBreakingNewsDesc.Text = "";
            // 
            // txtBoxBreakingNewsTitle
            // 
            this.txtBoxBreakingNewsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.txtBoxBreakingNewsTitle.Location = new System.Drawing.Point(15, 4);
            this.txtBoxBreakingNewsTitle.Name = "txtBoxBreakingNewsTitle";
            this.txtBoxBreakingNewsTitle.Size = new System.Drawing.Size(392, 36);
            this.txtBoxBreakingNewsTitle.TabIndex = 7;
            this.txtBoxBreakingNewsTitle.Text = "";
            // 
            // dlgBreakingNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 253);
            this.Controls.Add(this.txtBoxBreakingNewsTitle);
            this.Controls.Add(this.txtBoxBreakingNewsDesc);
            this.Name = "dlgBreakingNews";
            this.Text = "Breaking News!";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox txtBoxBreakingNewsDesc;
        private System.Windows.Forms.RichTextBox txtBoxBreakingNewsTitle;
    }
}