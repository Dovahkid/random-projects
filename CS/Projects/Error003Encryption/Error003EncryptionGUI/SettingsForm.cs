using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Error003EncryptionSdk;

namespace Error003EncryptionGUI
{
    public partial class SettingsForm : Form
    {

        public SettingsForm(List<IAddon> Addons)
        {
            InitializeComponent();
        }
    }
}
