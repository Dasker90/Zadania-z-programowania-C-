using System;
using static System.Math;

namespace Zadanie_25
{
    class Program
    {


        static void Main(string[] args)
        {
            double losuj_liczbe, zgadnij_liczbe;
            do
            {


                Random r = new Random();

                Console.WriteLine("Program losujacy liczby: ");

                losuj_liczbe = Round(10 * (r.NextDouble()));
                zgadnij_liczbe = double.Parse(Console.ReadLine());

                if (zgadnij_liczbe == losuj_liczbe)
                {
                    Console.WriteLine(" Piotruś Odgadłes !!!! ");

                }
                else
                {
                    Console.WriteLine("Bardzo mi przykro , ale wylosowane liczba to {0}. ", losuj_liczbe);

                }


            } while (losuj_liczbe != zgadnij_liczbe);


            
        }
    }
}
