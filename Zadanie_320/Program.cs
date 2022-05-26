using System;

namespace Zadanie_320
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, wiersz, kolumna;
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Program wyswietla tabliczke mnozenia dla liczb od 1 do 100.");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");

            wiersz = 1; //Wartość początkowa.

            do
            {
                kolumna = 1; // wartość początkowa.
                do
                {
                    Console.Write(wiersz * kolumna + "\t");  // "\t" wyswietla tabele.
                    kolumna++; //liczenie kolumn.
                }
                while (kolumna <= n);
                wiersz++;
                Console.WriteLine();
            }
            while (wiersz <= n);
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
