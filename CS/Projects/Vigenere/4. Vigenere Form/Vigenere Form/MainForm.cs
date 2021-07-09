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
    public partial class MainForm : Form
    {
        bool isEncrypting = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string strPlainText;
            string strKey;

            lblStatus.Text = string.Empty;

            try
            {
                if (Vigenere.Capitalize.isCapital)
                {
                    strPlainText = txtPlainText.Text.ToUpper();
                    strKey = txtKey.Text.ToUpper();
                }
                else
                {
                    strPlainText = txtPlainText.Text;
                    strKey = txtKey.Text;
                }


                for (int i = 0; i < strPlainText.Length; i++)
                {
                    if (!Vigenere.alphabet.Contains(strPlainText[i].ToString()))
                    {
                        strPlainText = strPlainText.Replace(strPlainText[i].ToString(), "");
                    }
                }

                for (int i = 0; i < strKey.Length; i++)
                {
                    if (!Vigenere.alphabet.Contains(strKey[i].ToString()))
                    {
                        strKey = strKey.Replace(strKey[i].ToString(), "");
                    }
                }


                switch (isEncrypting)
                {
                    case true:

                        lblOutput.Text = Vigenere.encrypt(strPlainText, strKey);
                        break;
                    case false:

                        lblOutput.Text = Vigenere.decrypt(strPlainText, strKey);
                        break;
                    default:
                        break;
                }
                
            }
            catch(Exception ex)
            {
                lblStatus.Text = "Please enter a valid string.";
            }
            
        }

        private void radEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            isEncrypting = true;
        }

        private void radDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            isEncrypting = false;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblOutput.Text);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.Show();
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfDialog = new SaveFileDialog())
            {
                string fileName;
                sfDialog.Filter = "Text Files (*.txt)|.txt";

                if (sfDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfDialog.FileName;

                    try
                    {
                        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName))
                        {
                            writer.Write(lblOutput.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            
        }

        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "Text Files (*.txt)|.txt";
                string filePath = string.Empty;
                string content = string.Empty;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = fileDialog.OpenFile();

                    using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                    {
                        content = reader.ReadToEnd();

                        txtPlainText.Text = content;
                    }
                }
            }
        }
    }
}
