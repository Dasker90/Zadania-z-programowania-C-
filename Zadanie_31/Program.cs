using System;

namespace Zadanie_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Zadanie 3.1");
            Console.WriteLine("Program oblicza wartosci funkcji y = 3*x");
            Console.WriteLine("dla x zmieniajacego sie od 0 do 10. " );
            Console.WriteLine();

            for (x = 0; x <=10; x++)
            {
                y = 3 * x;
                Console.WriteLine(" x = " +x+ "\t" + " y = "+y);
            }
            Console.WriteLine();
            
            
            int q, z;

            Console.WriteLine("Zadanie 3.1 B");
            Console.WriteLine("Program oblicza wartosci funkcji z = 5*q");
            Console.WriteLine("dla x zmieniajacego sie od 0 do 10. ");
            Console.WriteLine();

            for (q = 0; q <= 10; q++)
            {
                z = 5 * q;
                Console.WriteLine(" z = " + z + "\t" + " q = " + q);
            }
            Console.WriteLine();

            int a, b;

            Console.WriteLine("Zadanie 3.1 C");
            Console.WriteLine("Program oblicza wartosci funkcji b = 5*a");
            Console.WriteLine("dla x zmieniajacego sie od 0 do 10. ");
            Console.WriteLine();

            for (a = 0; a <= 10; a++)
            {
                b = 99 * a;
                Console.WriteLine(" a = " + a + "\t" + " b = " + b);
            }
            Console.WriteLine();
        }
    }
}
