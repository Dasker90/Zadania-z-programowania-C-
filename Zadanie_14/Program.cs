using System;
using static System.Math;

namespace Zadanie_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double r,objetosc;
            Console.WriteLine("Podaj promien r:");
            r = double.Parse(Console.ReadLine());

            objetosc = 4.0 * PI * r * r * r / 3;
            Console.WriteLine("Objetosc kuli o promieniu r =" + r + "wynosi:" + objetosc);
        }
    }
}
