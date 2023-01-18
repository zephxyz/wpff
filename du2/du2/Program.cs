using System;
using System.Threading;

namespace du2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            int[] crct = new int[10];
            int[] aswr = new int[10];
            bool giveup = false;
            bool[] check = new bool[10];
            int[] chyba = new int[10];
            string result;
            Console.WriteLine("Jaké malé násobení chcete procvičovat? (2-10)");
            while (!int.TryParse(Console.ReadLine(), out cislo) || cislo < 2 || cislo > 10)
                Console.WriteLine("Neplatné zadání!");

            Console.Clear();

            for (int u = 0; u < 10; u++)
            {
                crct[u] = (u + 1) * cislo;
                do
                {
                    Console.WriteLine("Násobilka " + cislo + "\n" + (u + 1) + "x" + cislo + " = ?");
                    while (!int.TryParse(Console.ReadLine(), out aswr[u]))
                        Console.WriteLine("Neplatné zadání! (Zadejte celé číslo...)");
                    check[u] = aswr[u] == crct[u];
                    if (!check[u])
                    {
                        Console.WriteLine("Špatná odpověd. Pokud se chcete vzdát napište OK");
                        giveup = Console.ReadLine().ToUpper() == "OK";
                        chyba[u]++;
                        Thread.Sleep(300);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Správná odpověď!");
                        Thread.Sleep(300);
                        Console.Clear();
                    }

                }
                while (!check[u] && !giveup);
            }
            for (int p = 0; p < 10; p++)
            {
                switch(check[p])
                {
                    case true:
                        result = "Správně!";
                        break;
                    case false:
                        result = "Přeskočeno";
                        break;
                }
                if (crct[p] / 100 == 1)
                    Console.WriteLine(p + 1 + "x" + cislo + " = " + crct[p] + "    " + result + " (" + chyba[p] + " chyb)");
                else if (crct[p] / 10 >= 1)
                    Console.WriteLine(p + 1 + "x" + cislo + " = " + crct[p] + "      " + result + " (" + chyba[p] + " chyb)");
                else
                    Console.WriteLine(p + 1 + "x" + cislo + " = " + crct[p] + "       " + result + " (" + chyba[p] + " chyb)");
            }
        }
    }
}
