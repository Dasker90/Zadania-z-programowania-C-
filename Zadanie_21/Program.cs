using System;

namespace Zadanie_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Z liczb a b c czy tworzą one trójke pitagorejska:");
            Console.WriteLine("Podaj a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = int.Parse(Console.ReadLine());

            if ((a*a+b*b)== c*c)
            {
                Console.Write("Liczby");
                Console.Write(" a = "+a+".");
                Console.Write(" b = "+b+".");
                Console.Write(" c = "+c);
                Console.WriteLine(" są trójką pitagorejską. ");
            }
            else
            {
                Console.Write("Liczby");
                Console.Write(" a = " + a + ".");
                Console.Write(" b = " + b + ".");
                Console.Write(" c = " + c);
                Console.WriteLine(" nie są trójką pitagorejską. ");
            }
        }
    }
}