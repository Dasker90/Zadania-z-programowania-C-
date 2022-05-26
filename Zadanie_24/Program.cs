using System;

namespace Zadanie_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            Console.WriteLine(" Program oblicza wartosc x z rownania liniowego ax+b=0  ");
            Console.WriteLine(" Podaj a. ");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine(" Niedozwolona wartosc wspołczynnika a: !!!!!");
            }
            else
            {
                Console.WriteLine(" Podaj b. ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine(" Podaj a. ");
                c = double.Parse(Console.ReadLine());

                x = (c - b) / a;

                Console.WriteLine();
                Console.WriteLine("Dla");
                Console.Write(" a = {0:##.##}, ", a);
                Console.Write(" b = {0:##.##}, ", b);
                Console.Write(" c = {0:##.##}, ", c);
                Console.WriteLine(" wartosc x = {0:##.##}. ",x);
            }
        }
    }
}
