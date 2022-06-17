using System;

namespace Zadanie_11
{
    class Program
    {
        static Void Main (string[] args)
        {
            double a, b, pole;

            Console.WriteLine("A.H.E | Informatyka | III rok");
            Console.WriteLine("Damian Skuraś");
            Console.WriteLine("Zadanie 1.1");

            Console.WriteLine("Program oblicza pole prostokata :");
            Console.WriteLine("Podaj bok a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok b:");
            b = double.Parse(Console.ReadLine());

            pole = a * b;

            Console.WriteLine("Pole prostokąta o boku a = {0} i boku b = {1}, a , b");
            Console.WriteLine("Wynosi {0}.",pole);

        }
    }
}
//---
