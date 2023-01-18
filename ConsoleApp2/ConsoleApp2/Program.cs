using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej sudé číslo");
            int cislo = int.Parse(Console.ReadLine());

            while ((cislo % 2) != 0) // podmínka
            {
            Console.WriteLine("Nezadal jsi sudé číslo.");
            cislo = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Zadal jsi číslo " + cislo + ".");
            Console.ReadKey();
        }
    }
}
