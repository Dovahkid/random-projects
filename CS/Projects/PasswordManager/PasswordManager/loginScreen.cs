using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography;

namespace PasswordManager
{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PassKeeper newKeeper;

            string username;
            string password;
            string account;
            string hashedPass;
            string storedHash;
            XmlDocument doc = new XmlDocument();
            
            try
            {
                username = txtUserName.Text;
                password = txtPassword.Text;
                account = username + ".xml";
            }
            catch (Exception ex)
            {
                MessageBox.Show("There has been an error loading your account");
                return;
            }

            doc.Load(account);
            XmlNode hashNode = doc.DocumentElement.SelectSingleNode("userPass");
            storedHash = hashNode.InnerText;

            hashedPass = Methods.hashPass(password);

            if (hashedPass == storedHash)
            {
                newKeeper = new PassKeeper(username, password);
                newKeeper.Show();
                this.Close();
            }
            else
            {
                lblStatus.Text = "Incorrect Username or Password";
            }
            
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount newAcc = new CreateAccount(); 
            newAcc.Show();
        }

    }
}
