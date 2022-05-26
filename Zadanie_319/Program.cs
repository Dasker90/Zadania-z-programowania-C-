using System;

namespace Zadanie_319
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, wiersz, kolumna;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Program wyswietla tabliczke mnożenia dla liczb od 1 do 100");
            Console.WriteLine();

            for (wiersz = 1; wiersz <= n; wiersz++)
            {
                for(kolumna = 1; kolumna <= n; kolumna++)
                {
                    Console.Write(wiersz*kolumna + "\n");
                }
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------");
            }

            int a = 10, wiersz1, kolumna1;
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Program wyswietla tabliczke mnożenia dla liczb od 1 do 100");
            Console.WriteLine();

            for (wiersz1 = 1; wiersz1 <= a; wiersz1++)
            {
                for (kolumna1 = 1; kolumna1 <= n; kolumna1++)
                {
                    Console.Write((wiersz1 * kolumna1) + "\t");
                }
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------");
            }

        }
    }
}
