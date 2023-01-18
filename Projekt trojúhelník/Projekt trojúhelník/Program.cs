using System;

namespace Projekt_trojúhelník
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            urcenistran: // 1. část kódu se zabývá zjišťováním hodnot stran trojúhelníku od uživatele

            Console.WriteLine("Zadejte stranu a."); 
            string a0 = Console.ReadLine(); // uživatel načte stranu a
            double a = double.Parse(a0);

            Console.Clear();

            Console.WriteLine("Zadejte stranu b.");
            string b0 = Console.ReadLine(); // uživatel načte stranu b
            double b = double.Parse(b0);

            Console.Clear();

            Console.WriteLine("Zadejte stranu c. (Nesmí být větší než {0} a musí být větší než {1})",(a+b),Math.Max(a,b)-Math.Min(a,b));
            string c0 = Console.ReadLine(); // uživatel získá možný rozsah jeho poslední délky strany c, načte stranu c
            double c = double.Parse(c0);
            
            Console.Clear();

            double max0 = Math.Max(a, b);  // zjišťování maximální hodnoty z proměných a, b, c pro další výpočty
            double max = Math.Max(max0, c);

            double a2 = Math.Pow(a, 2); // mocniny pro provedení Pythagorovy věty
            double b2 = Math.Pow(b, 2);
            double c2 = Math.Pow(c, 2);
            
            
            if ((a + b) > c && (a + c) > b && (b + c) > a) // kontrola, zda ze zadaných stran je možné sestrojit trojúhelník
            {
               
            }
            else // pokud není trojúhelník -> znovu zadat strany
            {
                Console.WriteLine("Toto není trojúhelník, zadejte znovu strany.");
                goto urcenistran;
            }
            if (a == b && a == c) // kontrola, zda jsou všechny strany shodné pro vyhodnocení rovnostrannosti
            {
                Console.WriteLine("Trojúhelník je rovnostranný.");
            }
            else if (a == b || a == c || b == c) // kontrola, zda jsou dvě strany shodné pro vyhodnocení rovnoramennosti
            {
                Console.WriteLine("Trojúhelník je rovnoramenný.");
            }

            if (max == a) // výpočet Pythagorovy věty za podmínky, že a má největší hodnotu 
            {
                if ((b2 + c2) == a2)
                {
                    Console.WriteLine("Trojúhelník je pravoúhlý.");
                }

            }
            else if (max == b) // výpočet Pythagorovy věty za podmínky, že b má největší hodnotu
            {
                if ((a2 + c2) == b2)
                {
                    Console.WriteLine("Trojúhelník je pravoúhlý.");
                }
            }
            else if (max == c) // výpočet Pythagorovy věty za podmínky, že c má největší hodnotu
            {
                if ((a2 + b2) == c2)
                {
                    Console.WriteLine("Trojúhelník je pravoúhlý.");
                }
                
            }
            if ((a2+b2) != c2 && (a2 + c2) != b2 && (c2 + b2) != a2 && a != b && a != c && b != c)  // kontrola zda je trojúhelník obecný pomocí vylučování
            {
                Console.WriteLine("Trojúhelník je obecný.");
            }
        }
    }
}
