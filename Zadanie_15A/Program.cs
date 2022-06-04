using System;

namespace Zadanie_15A
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Program wyswietla wynik dzielenia całkowitego:");
            Console.WriteLine("a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Dla liczb a=" + a + "i b=" + b);
            Console.WriteLine(a + "/" + b + "=" + a / b + ".");
        }
    }
}
#-
