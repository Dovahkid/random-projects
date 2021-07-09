using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_and_out
{
    class Program
    {
        static void refTest(ref int c)
        {

            c += 2;

        }

        static void outTest(out int d)
        {

            d = 10;

        }

        static void Main(string[] args)
        {
            int a = 1;
            int b;

            refTest(ref a);
            outTest(out b);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();

        }
    }
}
