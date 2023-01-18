using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte 1. číslo");
            int a = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 2. číslo");
            int b = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 3. číslo");
            int c = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 4. číslo");
            int d = int.Parse(Console.ReadLine());

            Console.Clear();

            if (a % 2 == 1)
            {
                Console.WriteLine("Číslo {0} je liché.", a);
            }
            else
            {
                Console.WriteLine("Číslo {0} je sudé.", a);
            }
            if (b % 2 == 1)
            {
                Console.WriteLine("Číslo {0} je liché.", b);
            }
            else
            {
                Console.WriteLine("Číslo {0} je sudé.", b);
            }
            if (c % 2 == 1)
            {
                Console.WriteLine("Číslo {0} je liché.", c);
            }
            else
            {
                Console.WriteLine("Číslo {0} je sudé.", c);
            }
            if (d % 2 == 1)
            {
                Console.WriteLine("Číslo {0} je liché.", d);
            }
            else
            {
                Console.WriteLine("Číslo {0} je sudé.", d);
            }

        }
    }
}
