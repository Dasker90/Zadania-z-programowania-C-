using System;

namespace Zadanie_322
{
    class Program
    {
        static void Main(string[] args)
        {
            char znak;


            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Program wyswietla duze litery alfabetu od A do Z i od Z do A ");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------");

            for (znak = 'A'; znak <= 'Z'; znak++)
            {
                if (znak < 'Z')
                    Console.Write(znak + ".");
                else
                {
                    Console.Write(znak + ".");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            for (znak = 'Z'; znak >= 'A'; znak--)
            {
                if (znak > 'A')
                    Console.Write(znak + ".");
                else
                {
                    Console.Write(znak + ".");
                    Console.WriteLine();
                }
            }

        }
    }
}
