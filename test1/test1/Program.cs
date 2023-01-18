using System;

namespace test1
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

            double min = a;
            if (b < a)
                min = b;
            if (c < b)
                min = c;
            
            int pocet = 0;
            if (a == min)
                pocet = ++pocet;
            if (b == min)
                pocet = ++pocet;
            if (c == min)
                pocet = ++pocet;
            Console.WriteLine("Minimální zadaná hodnota je " + min + " a mezi zadanými čísly se vyskytuje " + pocet + "x.");
        }
    }
}
