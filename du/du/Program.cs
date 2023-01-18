using System;

namespace du
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet = 0;
            int count = 0;
            int cislo;
            int arrinfos = 0;
            int arrinfol = 0;
            int kladne = 0;
            int zaporne = 0;
            int soucets = 0;
            int soucetl = 0;
            Console.WriteLine("Zadejte počet čísel...");

            while (!int.TryParse(Console.ReadLine(), out pocet) || pocet <= 0)
                Console.WriteLine("Zadejte kladné celé číslo! (ne 0)");
            int[] suda = new int[pocet];
            int[] licha = new int[pocet];

            for (pocet = pocet; pocet > 0; pocet--)
            {
                count++;
                Console.WriteLine("Zadejte " + count + ". číslo.");
                while (!int.TryParse(Console.ReadLine(), out cislo))
                    Console.WriteLine("Zadejte celé číslo!");
                if (cislo % 2 == 0)
                {
                    suda[arrinfos] = cislo;
                    arrinfos++;
                }
                else
                {
                    licha[arrinfol] = cislo;
                    arrinfol++;
                }
                if (cislo >= 0)
                    kladne++;
                else
                    zaporne++;
            }
            for (int i = 0; i < arrinfos; i++)
                soucets += suda[i];
            for (int u = 0; u < arrinfol; u++)
                soucetl += licha[u];
            Console.WriteLine("Součet sudých čísel: " + soucets + "\nSoučet lichých čísel: " + soucetl + "\nZe zadaných čísel bylo: " + kladne + " kladných a " + zaporne + " záporných.");
        }
    }
}
