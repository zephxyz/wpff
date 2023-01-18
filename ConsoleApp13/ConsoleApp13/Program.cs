using System;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mez;
            int soucet = 0;
            int cislo;
            int times = 0;
            bool check;
            Random rng = new Random();
            Console.WriteLine("Zadejte mezní hodnotu součtu.");
            do
            {
                check = int.TryParse(Console.ReadLine(), out mez);
                if (!check)
                    Console.WriteLine("Zadejte celé číslo!");
            }
            while (!check);

            do
            {
                times++;
                cislo = rng.Next(0, 6);
                soucet = soucet + cislo;
                Console.WriteLine("Vygenerované číslo - " + cislo + ", Součet = " + soucet + " (" + times + ". číslo)");
                
            }
            while (soucet <= mez);
            
            
        }
    }
}
