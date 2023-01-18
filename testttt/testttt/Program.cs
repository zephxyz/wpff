using System;

namespace testttt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hm = 0;
            int dm;
            int size = 0;
            int hranice = 0;
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
                pole_nahodne[i] = rng.Next(dm, hm+1);
                Console.Write(pole_nahodne[i] + " |");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Zadejte hranici pro rozdělení pole.");
            while (!int.TryParse(Console.ReadLine(), out hranice))
                Console.WriteLine("Zadejte celé číslo!");

            Console.WriteLine();

            int[] pole_vetsi = new int[size];
            int pocet_mensi = 0;
            pole_vetsi = pole_nahodne;

            for (int i = 0; i < size; i++)
            {
                if (pole_nahodne[i] < hranice)
                    pocet_mensi++;
            }
            Console.WriteLine("Počet hodnot menších než zadaná hraniční hodnota " + hranice + " je " + pocet_mensi + ".");

            Console.WriteLine();

            Console.WriteLine("Pole větších hodnot než zadaná hraniční hodnota " + hranice + " je:");

            int u = 0;
            for (int i = 0; i < size; i++)
            {
                if (pole_vetsi[i] <= hranice)
                    continue;

                pole_vetsi[u] = pole_nahodne[i];
                Console.Write(pole_vetsi[u] + " |");
                u++;
            }
            Console.ReadKey();



            

        }
    }
}
