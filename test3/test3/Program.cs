using System;

namespace test3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo, které chcete dělit.");
            string citatel = Console.ReadLine();
            int a = int.Parse(citatel);

            Console.Clear();

            Console.WriteLine("Zadejte dělitele.");
            string delitel = Console.ReadLine();
            int b = int.Parse(delitel);

            Console.Clear();

            int vysledek = a / b;
            int zbytek = a % b;

            if (zbytek == 0)
            {
                Console.WriteLine("Výsledek je " + vysledek + " a je beze zbytku.");
            }
            else
            {
                Console.WriteLine("Výsledek je " + vysledek + " se zbytkem " + zbytek + ".");
            }
        }
    }
}
