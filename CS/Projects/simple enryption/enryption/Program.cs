using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string key = "qwertyuiopasdfghjklzxcvbnm";
            string plainText = "";
            string output = "";

            Console.Write("Enter your text: ");
            plainText = Console.ReadLine();

            for (int i = 0; i < plainText.Length; i++)
            {
                for(int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == plainText[i])
                    {
                        output += key[j];
                    }
                }
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
