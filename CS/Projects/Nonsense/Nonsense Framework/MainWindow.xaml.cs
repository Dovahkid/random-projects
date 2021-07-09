using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nonsense_Framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int lastColor = 0;

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)Math.Pow(Convert.ToInt32(e.Key), 2);

            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom($"#{key + lastColor}");
            MainForm.Background = brush;

            lastColor = key;
        }

    }
}
