using System;

namespace a_test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mez, krok;
            
            Console.WriteLine("Zadej horní mez odpočítání > 0");
            while (!int.TryParse(Console.ReadLine(), out mez) || mez <= 0)
                Console.WriteLine("Zadejte celé číslo větší než 0!");

            Console.WriteLine("Zadej krok odpočítání větší než 0 a menší než horní mez");
            while (!int.TryParse(Console.ReadLine(), out krok) || krok > mez)
                Console.WriteLine("Zadejte celé číslo menší než horní mez!");

            for (int i = mez; i > 0; i -= krok)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("START!");

        }
    }
}
