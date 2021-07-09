using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov = 0, Dec };
        
        static void Main(string[] args)
        {

            int x = (int)Day.Sun;
            Console.WriteLine(x + "\n");

            Day y = Day.Mon;
            Console.WriteLine(y + "\n");
            
            Console.WriteLine((int)Month.Jan);
            Console.WriteLine((int)Month.Feb);
            Console.WriteLine((int)Month.Mar);
            Console.WriteLine((int)Month.Apr);
            Console.WriteLine((int)Month.May);
            Console.WriteLine((int)Month.Jun);
            Console.WriteLine((int)Month.Jul);
            Console.WriteLine((int)Month.Aug);
            Console.WriteLine((int)Month.Sep);
            Console.WriteLine((int)Month.Oct);
            Console.WriteLine((int)Month.Nov);
            Console.WriteLine((int)Month.Dec);
            
            Console.ReadKey();
        }
    }
}
