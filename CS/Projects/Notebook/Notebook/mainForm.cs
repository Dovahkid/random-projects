using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

/*
 
    IM SORRY

    This is really shit code
    like all of it, in every file. 
    Its flimsy and hard to maintain
    Its just indescribably bad
    IDK what im doing
 
     */

namespace Notebook
{
    public partial class mainForm : Form
    {
        public string title = "";
        public string date = "";
        public string fileName = "";
        public string bodyText = "";
        public mainForm()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                bodyText = rchBody.Text;
                NotebookFile.saveFile(bodyText, fileName);
            }
            else
            {
                bodyText = rchBody.Text; // <<---< Sets body text to whatever is in the rich text box 
                NotebookFile.newFile(bodyText); // so it can be passed to the save and read methods
                NotebookFile.readFile(ref title, ref date, ref fileName, ref bodyText);

                lblTitle.Text = title;
                rchBody.Text = bodyText; // After being read and returned the rich text box is set to the new bodyText value
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NotebookFile.readFile(ref title, ref date, ref fileName, ref bodyText))
            {
                lblTitle.Text = title;
                rchBody.Text = bodyText;
                return;
            }
            lblTitle.Text = "";
            rchBody.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(NotebookFile.newFile())
            {
                NotebookFile.readFile(ref title, ref date, ref fileName, ref bodyText);
                lblTitle.Text = title;
                rchBody.Text = bodyText;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // This will return values like:
            //  - date created
            //  - date modified
            //  - title of file
            //  - name of file
            //  In a message box or custom form
            MessageBox.Show("Not Implemented");
        }
    }
}
