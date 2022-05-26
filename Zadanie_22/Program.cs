using System;
using static System.Math;

namespace Zadanie_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Program ma liczyc pierwiastki rownania kwadratowego ax^2 + bx + c = 0 ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Podaj a. ");
            a = double.Parse(Console.ReadLine());
            if ( a == 0 )
            {
                Console.WriteLine("Niedozwolona wartosc wspolczynnika a.");
                Console.WriteLine("--------------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Podaj b. ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Podaj c. ");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------");

                delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine();
                    Console.Write("Dla ");
                    Console.Write(" a = {0} .", a);
                    Console.Write(" b = {0} .", b);
                    Console.Write(" c = {0} .", c);
                    Console.Write(" brak pierwiastków rzeczywistych. ");
                    Console.WriteLine("--------------------------------------------------------------------------");
                }
                else
                if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine();
                    Console.Write("Dla ");
                    Console.Write(" a = {0} .", a);
                    Console.Write(" b = {0} .", b);
                    Console.Write(" c = {0} .", c);
                    Console.WriteLine("trojmian ma jeden pierwiastek podwojny x1 = {0:##.##}.", x1);
                    Console.WriteLine("--------------------------------------------------------------------------");
                }
                else
                {
                    x1 = (-b - Sqrt(delta)) / (2 * a);
                    x2 = (-b + Sqrt(delta)) / (2 * a);
                    Console.WriteLine();
                    Console.Write("Dla ");
                    Console.Write(" a = {0} .", a);
                    Console.Write(" b = {0} .", b);
                    Console.Write(" c = {0} .", c);
                    Console.WriteLine("trojmian ma dwa pierwiastki x1 = {0:##.##}.  x2 = {1:##.##}. ", x1 , x2);
                    Console.WriteLine("--------------------------------------------------------------------------");
                }
            }
        }
    }
}
