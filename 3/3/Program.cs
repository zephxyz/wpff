using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte 1. číslo.");
            double a = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 2. číslo.");
            double b = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 3. číslo.");
            double c = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 4. číslo.");
            double d = double.Parse(Console.ReadLine());

            double pr = ((a + b + c + d) / 4);
            Console.WriteLine("Průměr je: {0}.", pr);
        }
    }
}
