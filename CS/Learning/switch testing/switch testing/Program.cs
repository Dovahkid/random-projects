using System;

namespace switch_testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 1;
            Console.WriteLine(Switch(ref value));
        }

        static int Switch(ref int x) 
        {
            switch (x++ switch { _ => x++ } switch { _ => x++ } switch { _ => x++ }, x)
            {
                case (1, 1): return 1;
                case (2, 2): return 2;
                case (3, 3): return 3;
                case (4, 4): return 4;
                default: Console.WriteLine("idk"); break;

            }
            return 0;
        }
    }
}

/*
 saw this disgusting code on reddit and have no idea what it does
 */
