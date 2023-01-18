using System;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hm = 0;
            int dm;
            int size = 0;
            int search = 0;
            Random rng = new Random();

            Console.WriteLine("Zadejte velikost pole.");
            while (!int.TryParse(Console.ReadLine(), out size) || size < 1)
                Console.WriteLine("Zadejte cele číslo větší než 0!");

            Console.WriteLine("Zadejte dolní mez generování hodnot.");
            while (!int.TryParse(Console.ReadLine(), out dm))
                Console.WriteLine("Zadejte celé číslo!");

            Console.WriteLine("Zadejte horní mez generování hodnot.");
            while (!int.TryParse(Console.ReadLine(), out hm) || hm < dm)
                Console.WriteLine("Zadejte celé číslo, které je větší než dolní mez!");



            int[] pole_nahodne = new int[size];

            Console.WriteLine("Vygenerované pole:\n");

            for (int i = 0; i < size; i++)
            {
                pole_nahodne[i] = rng.Next(dm, hm + 1);
                Console.Write(pole_nahodne[i] + " | ");
            }

            Console.WriteLine("\n");

            string L = "";
            int found = 0;

            Console.WriteLine("Zadejte hledanou hodnotu.");
            while (!int.TryParse(Console.ReadLine(), out search))
                Console.WriteLine("Zadejte celé číslo, které je větší než dolní mez!");
            for (int i = 0; i < size; i++)
            {
                if (pole_nahodne[i] == search)
                {
                    L = L + i.ToString() + " | ";
                    found++;
                }
            }
            Console.WriteLine("Hodnota " + search + " se vyskytuje celkem " + found + "krát.");
            Console.WriteLine("\nVyskytuje se na místech: \n" + L);
            int min = pole_nahodne[0];
            int max = pole_nahodne[0];

            int minct = 0;
            int maxct = 0;
            for (int i = 1; i < size; i++)
            {
                if (min > pole_nahodne[i])
                {
                    min = pole_nahodne[i];

                }

                if (max < pole_nahodne[i])
                {
                    max = pole_nahodne[i];

                }

            }
            for (int i = 0; i < size; i++)
            {
                if (max == pole_nahodne[i])
                    maxct++;
                if (min == pole_nahodne[i])
                    minct++;
            }
            int[] mininf = new int[minct];
            int[] maxinf = new int[maxct];
            int u = 0;
            int j = 0;
            for (int i = 0; i < size; i++)
            {
                if (pole_nahodne[i] != max && pole_nahodne[i] != min)
                    continue;
                if (max == pole_nahodne[i])
                {
                    maxinf[u] = i;
                    u++;
                }
                if (min == pole_nahodne[i])
                {
                    mininf[j] = i;
                    j++;
                }
            }

            Console.WriteLine("Minimální hodnota je " + min + " a vyskytuje se " + minct + "krát na místech:");
            for (int i = 0; i < minct; i++)
            {
                Console.Write(mininf[i] + " | ");
            }
             
            Console.WriteLine();

            Console.WriteLine("Maximální hodnota je " + max + " a vyskytuje se " + maxct + "krát na místech:");
            for (int i = 0; i < maxct; i++)
            {
                Console.Write(maxinf[i] + " | ");
            }
        }
    }
}
