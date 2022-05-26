using System;
using static System.Math;

namespace Zadanie_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyswietla pierwiastek kwadratowy");
            Console.WriteLine("z dokladnoscia do dwoch miejsc po przecinku");
            Console.WriteLine("Sqrt(pi) = {0:#.##}.", Sqrt(PI));
        }
    }
}
