using System;
using System.Diagnostics;
using System.Threading;

namespace Zadanie_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Program wyświetla stałą PI z zadaną dokładnościa:");
            Console.WriteLine("PI = {0:#.##########}.", Math.PI);
            Console.WriteLine("----------------------");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(10000);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------");
        }
    }
}
