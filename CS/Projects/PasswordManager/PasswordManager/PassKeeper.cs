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

using vigenere_library;

namespace PasswordManager
{
    public partial class PassKeeper : Form
    {

        private static string username;
        private static string password;

        private static List<string> users = new List<string>();
        private static List<string> passwords = new List<string>();

        public PassKeeper()
        {
            InitializeComponent();
            
        }

        public PassKeeper(string us, string pw)
        {
            InitializeComponent();

            username = us;
            password = pw;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void PassKeeper_Load(object sender, EventArgs e)
        {
            using (XmlReader xmlRead = XmlReader.Create(username + ".xml"))
            { 
                    
            }
        }
    }
}
