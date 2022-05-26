using System;

namespace Zadanie_37
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1, suma = 0; //Ustalenie wartosci poczatkowych.
            Console.WriteLine("Program sumuje liczby całkowite od 1 do 100 ");
            Console.WriteLine();

            do
            {
                // suma = suma+i.
                suma += i; // suma + i;
                i++; // Inkrementacja - Dekrementacja.
            }
            while (i <= 100);
            {
                Console.WriteLine("Suma liczb od 1 do 100 wynosi |" + suma + ".");
            }
        }
    }
}
