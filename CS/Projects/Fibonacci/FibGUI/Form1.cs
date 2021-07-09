using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double fibo(int n)
        {
            double dblPhi = 0;
            double dblFibAprox = 0;
            string strFibAprox = "";
            int subOfDec = 0;
            int intIndexOfDec = 0;
            double answer = 0;

            try
            {
                dblPhi = (1 + Math.Pow(5, .5)) / 2;

                dblFibAprox = (Math.Pow(dblPhi, n)) / (Math.Pow(5, .5));

                //strFibAprox = Convert.ToString(dblFibAprox); // This might be a really stupid way of doing this but basically it converts the 
                //                                             // number to a string then grabs the decimal in a substring. did this to try to preserve the decimal as much as possible
                //                                             // Is probably super inefficient and proabably not very accurate
                //                                             // If I wanted to do it with math I could do modulo to get the decimal value instead
                //subOfDec = strFibAprox.IndexOf(".");
                //intIndexOfDec = Convert.ToInt32(strFibAprox.Substring(subOfDec + 1, 1));
                
                answer = dblFibAprox % 1 > 5 /*intIndexOfDec > 0.5*/ ? Math.Ceiling(dblFibAprox) : Math.Floor(dblFibAprox);

                
                // I want to make it more accurate beyond 71 but cant figure out how.
                // tried using decimal instead of double and writing my own power functions but was less accurate. Maybe I was on to something but my math was off somewhere

                return answer;
            }
            catch
            {
                return 1;
            }
        }

        private void btnFib_Click(object sender, EventArgs e)
        {
            lstAnswers.Items.Clear();

            int length = -1;
            try
            {
                length = Convert.ToInt32(txtNum.Text);
                if (length >= 72) 
                {
                    MessageBox.Show("This calculator is not accurate beyond 71. The 71st digit is the last correct digit.");
                }
            }
            catch
            {
                lblStatus.Text = "Use numbers only!";
            }

            string answers = string.Empty;

            if (radSeries.Checked == true)
            {
                for (int i = 0; i <= length; i++)
                {
                    lstAnswers.Items.Add(i + ". " + fibo(i));
                    //answers += fibo(i) + ", ";
                }
            }
            else
            {
                lstAnswers.Items.Add(fibo(length));
                //answers += fibo(length);
            }
            //lblFib.Text = answers;

        }

        private void radSeries_CheckedChanged(object sender, EventArgs e)
        {
            lblNum.Text = "How many numbers do you want to generate?";
        }

        private void radSingle_CheckedChanged(object sender, EventArgs e)
        {
            lblNum.Text = "What numbers, n, do you want to find?";
        }
    }
}
