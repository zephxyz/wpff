using System;

namespace for1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            bool check;
            int mincislo = 0;
            int nr = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                do
                {
                    check = int.TryParse(Console.ReadLine(), out a[(i - 1)]);
                }
                while (!check);
            }
            int arr1 = 0;
            int arr2 = 1;
            int min = a[0];

            do
            {
                min = Math.Min(min, Math.Min(a[arr1],a[arr2]));
                arr1 += 2;
                arr2 += 2;
            }
            while (arr2 <= 9);

            bool bruh;

            do
            {
                if (a[nr] == min)
                    mincislo = nr+1;
                nr++;
                bruh = mincislo > 0 && mincislo < 10;
            }
            while (!bruh);

            Console.WriteLine(min + " - " + mincislo + ".");
            

        }
    }
}
