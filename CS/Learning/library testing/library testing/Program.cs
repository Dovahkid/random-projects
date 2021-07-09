using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fibonacci_Library;

namespace library_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            fibonacci fib = new fibonacci();

            Console.Write(fib.generate(10, 0));

            Console.ReadKey();

        }
    }
}
