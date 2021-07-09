using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vignere_library;

namespace vignere_testing
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(vig.encrypt("michi", "houghton"));
            Console.WriteLine(vig.decrypt("twwnp", "houghton"));
            Console.ReadKey();
        }
    }
}
