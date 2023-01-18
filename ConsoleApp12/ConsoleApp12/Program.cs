using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int cislo;
            int min = 11;
            do
            {
                cislo = rng.Next(-10, 11);
                if (cislo != 0)
                Console.WriteLine(cislo);
                if (min > cislo)
                    min = cislo;


            } while (cislo != 0);
            Console.WriteLine("Nejmenší z vygenerovaných čísel bylo " + min);
            Console.ReadKey();
        }
    }
}
