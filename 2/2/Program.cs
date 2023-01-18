using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte 1. číslo.");
            double a = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 2. číslo.");
            double b = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 3. číslo.");
            double c = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 4. číslo.");
            double d = double.Parse(Console.ReadLine());

            double max = 0;

            if (a>=b && a>=c && a>=d)
            {
                max = a;
            }
            else if (b>=a && b>=c && b>=d)
            {
                max = b;
            }
            else if (c>=a && c>=b && c>=d)
            {
                max = c;
            }
            else
            {
                max = d;
            }
            if (max == a && max == b && max == c && max == d)
            {
                Console.WriteLine("Maximální hodnota je: {0}, a vyskytuje se 4krát.", max);
            }
            else if ((max == a && max == b && max == c && max>d) || (max == b && max == c && max == d && max>a) || (max == c && max == d && max == a && max>b) || (max == d && max == a && max == b && max>c))
            {
                Console.WriteLine("Maximální hodnota je: {0}, a vyskytuje se 3krát.", max);
            }
            else if ((max == a && max == b) || (max == b && max == c) || (max == c && max == d) || (max == d && max == a) || (max == a && max == c) || (max == b && max == d)) 
            {
                Console.WriteLine("Maximální hodnota je: {0}, a vyskytuje se 2krát.", max);
            }
            else
            {
                Console.WriteLine("Maximální hodnota je: {0}, a vyskytuje se 1krát.", max);
            }
            

            
        }
    }
}
