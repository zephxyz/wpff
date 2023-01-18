using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int cislo;
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                cislo = rng.Next(1, 10000);
                max = Math.Max(cislo, max);
                Console.WriteLine(cislo);
            }
            Console.WriteLine(max);
        }
    }
}
