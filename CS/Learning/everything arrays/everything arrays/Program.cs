using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace everything_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] normalArray1 = new int[5]; // array of size 5. Empty
            int[] normalArray2 = new int[] { 0, 1, 2, 3, 4 }; // array of size 5 with preset values
            int[] normalArray3 = { 0, 1, 2, 3, 4 }; // array of size 5 with preset values

            int[,] multiDimensionalArray1 = new int[3, 4]; // 2D multi-dimensional array of 3 rows and 4 columns. Empty
            int[,,] multiDimensionalArray2 = new int[3, 4, 5]; // 3D multi-dimensional array of 3 rows, 4 columns, and 5... 'Z' axis somethings. Empty

            int[,] multiDimensionalArray3 = new int[3, 4] 
            { 
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            }; // here's the 2D array

            int[,,] multiDimArr4 = new int[2, 3, 4] 
            {
                {
                    { 1, 2, 3, 4 }, 
                    { 5, 6, 7, 8 }, 
                    { 9, 10, 11, 12 }
                }, 
                {
                    { 13, 14, 15, 16 }, 
                    { 17, 18, 19, 20 }, 
                    { 21, 22, 23, 24 }
                }
            }; // 3D array

            Console.WriteLine(multiDimensionalArray3[1,3]); // The 4th item, in the 2nd array. Returns 8

            Console.WriteLine(multiDimArr4[1,1,3]); // The 4th item, in the 2nd array, in the 2nd group. Returns 20
            Console.ReadKey();

        }
    }
}
