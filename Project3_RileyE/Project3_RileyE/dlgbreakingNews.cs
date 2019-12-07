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
    public partial class dlgBreakingNews : Form
    {
        public dlgBreakingNews(String title, String desc)
        {
            InitializeComponent();

            txtBoxBreakingNewsTitle.Text = title;
            txtBoxBreakingNewsDesc.Text = desc;



        }

        
}


}
