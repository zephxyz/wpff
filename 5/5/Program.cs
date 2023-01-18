using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo");
            string a0 = Console.ReadLine();
            int a = int.Parse(a0);

            Console.Clear();

            Console.WriteLine("Zadejte dělitele");
            string d0 = Console.ReadLine();
            int d = int.Parse(d0);

            Console.Clear();

            int vysledek = a / d;
            int zbytek = a % d;
            if (zbytek == 0)
            {
                Console.WriteLine("Výsledek je {0} a je beze zbytku.", vysledek);
            }
            else
            {
                Console.WriteLine("Výsledek je {0} se zbytkem {1}.", vysledek, zbytek);
            }
        }
    }
}
