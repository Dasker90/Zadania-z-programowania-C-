using System;
using static System.Math;

namespace Zadanie_316
{
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc_liczb = 5, i;
            double liczba, suma = 0, min, max;
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Program losuje" +ilosc_liczb+ " liczb całkowitych od 0 do 99 ");
            Console.WriteLine("a nastepnie znajduje najmniejsza i najwieksza ");
            Console.WriteLine("oraz oblicza srednia ze wszystkich wylosowanych liczb");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine();
            Random r = new Random();
            min = Round(100 * (r.NextDouble()));
            Console.WriteLine();
            Console.WriteLine("Wylosowano liczby: |" +min+ "|");
            max = min;
            // suma = suma + max
            suma += max;

            for ( i=2; i <= ilosc_liczb; i++) // implementacja
            {
                liczba = Round(100 * (r.NextDouble()));
                if (i < ilosc_liczb)
                    Console.Write(liczba + ",");
                else
                {
                    Console.Write(liczba + ",");
                    Console.WriteLine();
                }
                if (max < liczba) max = liczba;
                if (liczba < min) min = liczba;
                // suma = suma+liczba
                suma += liczba;

            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Najwieksza liczba to: |" +max+ " |.");
            Console.WriteLine();
            Console.WriteLine("Najmniejsza liczba to: |" + min + " |.");
            Console.WriteLine();
            Console.WriteLine("Srednia wynosi: |" + suma/ilosc_liczb + " |.");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------");
        }
    }
}
