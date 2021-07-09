using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using vigenere_library;

namespace Vigenere_Form
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        
        private void Settings_Load(object sender, EventArgs e)
        {
            cmbAlphabet.Text = Vigenere.alphabet;

            chkCapitalization.Checked = Vigenere.Capitalize.isCapital;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(cmbAlphabet.Text.Length <= 0)
            {
                MessageBox.Show("Invalid alphabet");
            }
            else
            {
                Vigenere.alphabet = cmbAlphabet.Text;
            }

            if (chkCapitalization.Checked)
            {
                Vigenere.Capitalize.enable();
            }
            else
            {
                Vigenere.Capitalize.disable();
            }
        }

        private void btnSaveDefault_Click(object sender, EventArgs e)
        {
            //This button saves the settings for the program into a seperate file that can be accessed and edited later
        }
    }
}
