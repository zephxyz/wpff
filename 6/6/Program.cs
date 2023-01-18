using System;

namespace _6
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

            (a, d) = (d, a);
            (b, d) = (c, d);
            Console.WriteLine("{0},{1},{2},{3}",a,b,c,d);
        }
    }
}
