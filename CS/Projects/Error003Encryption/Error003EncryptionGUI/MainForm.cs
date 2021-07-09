using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

using Error003EncryptionSdk;
using Error003AddonManager;

namespace Error003EncryptionGUI
{
    public partial class MainForm : Form
    {
        public static List<IAddon> Addons = null;

        static string FilePath = string.Empty;

        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        public MainForm()
        {
            InitializeComponent();

            StartUpProcess();
        }

        void StartUpProcess()
        {
            Directory.CreateDirectory("logs");
            Directory.CreateDirectory("addons");

            try
            {
                Addons = AddonManager<IAddon>.ReadAddons();
            }
            catch (NoAddonsFoundException ex)
            {
                lblStatus.Text = ex.Message;
                return;
            }

            foreach (var addon in Addons)
            {
                lstEncryptionTypes.Items.Add(addon.name);
            }

            if (lstEncryptionTypes.Items.Count > 0)
            {
                lstEncryptionTypes.SelectedIndex = 0;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();

            FilePath = ofd.FileName;
            lblInputFilePath.Text = FilePath;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string password;
            password = txtPassword.Text;

            GCHandle gch = GCHandle.Alloc(password, GCHandleType.Pinned);

            if (FilePath.Equals(string.Empty))
            {
                lblStatus.Text = "A File Path is required";
                return;
            }

            if (password.Equals(""))
            {
                lblStatus.Text = "A password is required";
                return;
            }

            foreach (var addon in Addons)
            {
                if (addon.name.Equals(lstEncryptionTypes.SelectedItem))
                {
                    switch (radEncrypt.Checked)
                    {
                        case true:
                            addon.FileEncrypt(FilePath, password);
                            ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                            gch.Free();
                            MessageBox.Show("Done! The original file has not been deleted");
                            break;

                        case false:
                            addon.FileDecrypt(FilePath, password);
                            ZeroMemory(gch.AddrOfPinnedObject(), password.Length * 2);
                            gch.Free();
                            MessageBox.Show("Done! The encrypted file has not been deleted");
                            break;
                    }
                }
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sForm = new SettingsForm(Addons);
            sForm.ShowDialog();
        }

        private void radTextKey_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            btnFileKeyBrowse.Enabled = false;
        }

        private void radFileKey_CheckedChanged(object sender, EventArgs e)
        {
            //txtPassword.Enabled = false;
            //btnFileKeyBrowse.Enabled = true;
            lblStatus.Text = "This feature is not yet available";
            radTextKey.Checked = true;
        }

        private void btnFileKeyBrowse_Click(object sender, EventArgs e)
        {
        }
    }
}
