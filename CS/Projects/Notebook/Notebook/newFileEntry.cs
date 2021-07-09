using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notebook
{
    public partial class newFileEntry : Form
    {
        public string fileName { get; set; }
        public string fileTitle { get; set; }
        public newFileEntry()
        {
            InitializeComponent();
            txtNewFileName.Text = "";
            txtTitle.Text = "";
        }

        private void newFileEntry_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fileName = txtNewFileName.Text;
            fileTitle = txtTitle.Text;
            if (fileName == "" || fileTitle == "")
            {
                fileName = fileName == "" ?  DateTime.Now.ToString("MM-dd-yyyy") : fileName;
                fileTitle = fileTitle == "" ? fileName : fileTitle;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
