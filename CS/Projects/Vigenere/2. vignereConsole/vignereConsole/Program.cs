using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vignereConsole
{
    class vignere
    {

        public string encrypt(string plainText, string key)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int temp;
            int overFlow;
            int keyOverFlow = 0;
            string vigOutput = "";

            plainText = plainText.ToUpper();
            key = key.ToUpper();

            for (int i = 0; i <= plainText.Length - 1; i++)
            {

                if (i > key.Length - 1)
                {
                    keyOverFlow += 1;
                    if (keyOverFlow > key.Length - 1)
                    {
                        keyOverFlow = 0;
                    }
                }
                else
                {
                    keyOverFlow = i;
                }
                temp = alphabet.IndexOf(key[keyOverFlow]) + alphabet.IndexOf(plainText[i]);
                if (temp >= 26)
                {
                    overFlow = temp - 26;
                    vigOutput += alphabet[overFlow];
                }
                else
                {
                    vigOutput += alphabet[temp];
                }
                
            }

            return vigOutput;
        }

        public string decrypt(string plainText, string key)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int temp;
            int overFlow;
            int keyOverFlow = 0;
            string vigOutput = "";

            plainText = plainText.ToUpper();
            key = key.ToUpper();

            for (int i = 0; i <= plainText.Length - 1; i++)
            {

                if (i > key.Length - 1)
                {
                    keyOverFlow += 1;
                    if (keyOverFlow > key.Length - 1)
                    {
                        keyOverFlow = 0;
                    }
                }
                else
                {
                    keyOverFlow = i;
                }
                temp = alphabet.IndexOf(plainText[i]) - alphabet.IndexOf(key[keyOverFlow]);
                if (temp >= 26)
                {
                    overFlow = temp - 26;
                    vigOutput += alphabet[overFlow];
                }
                else if (temp < 0)
                {
                    overFlow = 26 + temp;
                    vigOutput += alphabet[overFlow];
                }
                else
                {
                    vigOutput += alphabet[temp];
                }

            }

            return vigOutput;

        }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            vignere vig = new vignere();
            Console.WriteLine(vig.encrypt("michi", "houghton"));
            Console.WriteLine(vig.decrypt("twwnp", "houghton"));
            Console.ReadKey();

        }
    }
}
