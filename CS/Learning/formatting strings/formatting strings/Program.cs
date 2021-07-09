using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formatting_strings
{
    class Program
    {
        static void Main(string[] args)
        {

            // Formatting & Substring
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string toBeReplaced = "Michael Joseph Gain JR.";

            string firstr = "Michael";
            string substr = firstr.Substring(0, 3);
            string substr2 = firstr.Substring(3, 4);

            Console.WriteLine("{0} = {1} + {2}", firstr, substr, substr2); // this has symbols inbetween the variables
            Console.WriteLine("{0} equals {1}{2}", firstr, substr, substr2); // this has a word inbetween

            Console.WriteLine("{2}{1}{0}", alphabet.Substring(2, 1), alphabet.Substring(8, 1), alphabet.Substring(12,1)); // this prints the stuff in a different order
                                                                                                                          // than how the variables

            // Replacing strings
            Console.WriteLine(toBeReplaced.Replace("Joseph", "J."));

            Console.WriteLine(toBeReplaced);

            toBeReplaced = toBeReplaced.Replace(toBeReplaced, "M.J.G. JR.");

            Console.WriteLine(toBeReplaced);

            Console.WriteLine(toBeReplaced.Replace("XYZ", "Test")); // "XYZ" is not in the string so it just doesnt do anything

            toBeReplaced = "This Is A Test";

            Console.WriteLine(toBeReplaced.Replace(" ", "")); // finds all instances of that thing in a string and changes it

            // Index of
            string indexOfTest = "Orange Banana Apple";
            Console.WriteLine("Orange location: " + indexOfTest.IndexOf("Orange"));


            Console.ReadKey();
        }
    }
}
