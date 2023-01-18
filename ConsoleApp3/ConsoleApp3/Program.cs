using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int cislo;
            do
            {
                Console.WriteLine("Zadej číslo:");
                cislo = int.Parse(Console.ReadLine());
                if (cislo % 2 == 0)
                    n--;
                else
                    m--;
            }
            while (n > 0 && m > 0);
            Console.WriteLine("Konec");
        }
    }
}
