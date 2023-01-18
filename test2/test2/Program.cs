using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte 1. číslo.");
            string cisloa = Console.ReadLine();
            double a = double.Parse(cisloa);

            Console.Clear();

            Console.WriteLine("Zadejte 2. číslo.");
            string cislob = Console.ReadLine();
            double b = double.Parse(cislob);

            Console.Clear();

            Console.WriteLine("Zadejte 3. číslo.");
            string cisloc = Console.ReadLine();
            double c = double.Parse(cisloc);

            Console.Clear();

            Console.WriteLine("Zadejte 4. číslo.");
            string cislod = Console.ReadLine();
            double d = double.Parse(cislod);

            Console.Clear();

            double prumer = (a + b + c + d) / 4;
            Console.WriteLine("Průměr zadaných čísel je: " + prumer);
            Console.ReadKey();
        }
    }
}
