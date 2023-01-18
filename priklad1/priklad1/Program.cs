using System;

namespace priklad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik hodnot chcete sečíst?");
            int array;
            bool check0;
            do
            {
                check0 = int.TryParse(Console.ReadLine(), out array);
                if (!check0)
                    Console.WriteLine("Zadejte celé číslo!");
            }
            while (!check0);
            int[] a = new int[array];
            int which = 0;
            bool check;

            int minnr;
            int vysl = 0;
            for (int i = 1; i <= array; i++)
            {
                Console.WriteLine("Zadejte " + i + " číslo.");
                check = int.TryParse(Console.ReadLine(), out a[which]);
                if (check)
                {
                    vysl = a[which] + vysl;
                    
                    which++;
                }
                else
                    i--;
            }
            Console.WriteLine(vysl);

            
            
        }
    }
}
