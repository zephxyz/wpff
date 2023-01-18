using System;

namespace výpočty
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("Zadejte číslo.");
                a = int.Parse(Console.ReadLine());
            }
            while (a == 0);

            while ((a % 2 == 0 || a % 2 != 0) && a != 1)
            {
                while (a % 2 == 0)
                {
                    a = a / 2;
                    Console.Write(a + " - ");
                }
                while (a % 2 != 0 && a != 1)
                {
                    a = 3 * a + 1;
                    Console.Write(a + " - ");
                }
            }
            Console.WriteLine("... 4, 2, 1 loop");

        }
    }
}
