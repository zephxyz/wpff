using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int max = -11;
            int pocet;
            int nrcislo = 0;
            int cislo;
            bool check;
            Console.WriteLine("Kolik chcete vygenerovat hodnot?");
            do
            {
                check = int.TryParse(Console.ReadLine(), out pocet);
                if (!check)
                    Console.WriteLine("Zadejte celé číslo!");
            }
            while (!check);

            do
            {
                nrcislo++;
                cislo = rng.Next(-10, 11);
                Console.WriteLine(cislo + " (" + nrcislo + ". číslo.)");
                if (max < cislo)
                    max = cislo;
                pocet--;
            }
            while (pocet > 0);
            Console.WriteLine("Maximální vygenerovaná hodnota: " + max);
        }
    }
}
