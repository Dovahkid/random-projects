using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PasswordManager
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            string repeatPass = "";
            string hashPass;
            string message = "";
            bool quitFlag = false;

            try
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                repeatPass = txtRepeatPass.Text;
            }
            catch
            {
                MessageBox.Show("There was some error... idk what it was");
                return;
            }
            
            if (!Methods.isValidUsername(username)) // Checks to see if the user name is valid
            {
                message += "Invalid Username\n";
                quitFlag = true;
            }

            if (!Methods.isValidPassword(password, repeatPass)) // Checks to see if the password is valid
            {
                message += "Invalid password or they dont match";
                quitFlag = true;
            }

            if (quitFlag)
            {
                MessageBox.Show(message);
                return;
            }

            hashPass = Methods.hashPass(password); // Sends password to be hashed

            using (XmlWriter writer = XmlWriter.Create(username + ".xml"))
            {
                writer.WriteStartElement("userInfo");
                writer.WriteElementString("userName", username);
                writer.WriteElementString("userPass", hashPass);
                writer.WriteElementString("userNames", " ");
                writer.WriteElementString("passwords", " ");
                writer.WriteEndElement();
            }
            MessageBox.Show("Account Created!");
            this.Close();

        }
        
    }
}
