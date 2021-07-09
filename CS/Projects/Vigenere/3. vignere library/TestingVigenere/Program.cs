using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vigenere_library;

namespace TestingVigenere
{
    class Program
    {
        static void Main(string[] args) 
        {

            using (new StopW())
            {
                Console.WriteLine(Vigenere.encrypt("thisisareallylongstringimjustwritingrandomstufftomakeareallylongstringtotestprogramefficiency", "houston"));
            }
            
            Console.ReadKey();

        }
    }
}
