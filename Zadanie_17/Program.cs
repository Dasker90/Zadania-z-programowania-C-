using System;

namespace Zadanie_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, suma, roznica, iloczyn, iloraz;

            Console.WriteLine("Podaj X:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Y:");
            y = double.Parse(Console.ReadLine());

            suma = x + y;
            roznica = x - y;
            iloczyn = x * y;
            iloraz = x / y;

            Console.WriteLine("Dla x = {0:##.##} i y = {1:##.##}", x, y);
            Console.WriteLine("suma = {0:##.##}|", suma);
            Console.WriteLine("roznica = {0:##.##}|", roznica);
            Console.WriteLine("iloraz = {0:##.##}|", iloraz);
            Console.WriteLine("iloczyn = {0:##.##}|", iloczyn);
        }
    }
}
