using System;

namespace a_test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            int pocet = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Zadej " + i + ". číslo: ");
                while (!int.TryParse(Console.ReadLine(), out cislo))
                    Console.WriteLine("Zadejte celé číslo!");
                if (cislo % 2 == 1)
                    pocet++;
            }
            Console.WriteLine("Počet zadaných lichých čísel je " + pocet + ".");
        }
    }
}
