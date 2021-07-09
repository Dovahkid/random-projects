using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingVigenere
{
    class StopW : IDisposable
    {

        Stopwatch sw = new Stopwatch();
        long timeElapsed;
        
        public StopW()
        {
            sw.Start();
        }

        public void Dispose()
        {
            sw.Stop();
            timeElapsed = sw.ElapsedMilliseconds;
            Console.WriteLine("Time Elapased: " + timeElapsed);
        }

    }
}
