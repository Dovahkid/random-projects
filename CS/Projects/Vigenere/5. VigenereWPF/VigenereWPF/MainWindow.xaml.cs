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

using vigenere_library;

namespace VigenereWPF
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string key;
            string inputText;
            string outputText;

            key = txtKey.Text;
            inputText = txtInputText.Text;

            if (radEncrypt.IsChecked == true)
            {
                outputText = encrypt(inputText, key);
            }
            else
            {
                outputText = decrypt(inputText, key);
            }

            lblOutput.Content = outputText;

        }

        private string encrypt(string input, string key)
        {
            string output;
            output = Vigenere.encrypt(input, key);

            return output;
        }

        private string decrypt(string input, string key)
        {
            string output;
            output = Vigenere.decrypt(input, key);

            return output;
        }
    }
}
