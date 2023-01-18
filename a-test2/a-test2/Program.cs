using System;

namespace a_test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times;
            double cislo;
            double max = 0;
            double min = 0;
            int mininf = 1;
            int maxinf = 1;
            Console.WriteLine("Zadej z kolika hodnot chceš najít minimum a maximum");
            while (!int.TryParse(Console.ReadLine(), out times) || times < 1)
                Console.WriteLine("Zadejte celé číslo větší než 0!");

            for (int i = 1; i <= times; i++)
            {
                Console.Write("Zadej " + i + ". číslo: ");
                while (!double.TryParse(Console.ReadLine(), out cislo))
                    Console.WriteLine("Zadejte reálné číslo!");
                if (i == 1)
                {
                    max = cislo;
                    min = cislo;
                }
                else
                {
                    if (cislo > max)
                    {
                        max = cislo;
                        maxinf = i;
                    }
                    else if (cislo < min)
                    {
                        min = cislo;
                        mininf = i;
                    }
                }
                    

            }
            Console.WriteLine("Minimum ze zadaných čísel je: " + min + " a bylo zadáno jako " + mininf + ". číslo." +
                "\nMaximum ze zadaných čísel je: " + max + " a bylo zadáno jako " + maxinf + ". číslo.");


        }
    }
}
