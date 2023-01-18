using System;
using System.Threading;

namespace pole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocet;
            Console.WriteLine("Kolik je bytů?");
            
            while(!int.TryParse(Console.ReadLine(), out pocet))
                Console.WriteLine("Zadejte celé číslo");
            string[] jmeno = new string[pocet];
            string[] prijmeni = new string[pocet];

            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine("Napište jméno obyvatele " + (i + 1) + ". bytu.");
                jmeno[i] = Console.ReadLine();
                Thread.Sleep(100);

                Console.Clear();

                Console.WriteLine("Napište příjmení obyvatele " + (i + 1) + ". bytu.");
                prijmeni[i] = Console.ReadLine();
                Thread.Sleep(100);

                Console.Clear();
            }
            for (int i = 0; i < pocet; i++)
            {
                Console.WriteLine(i+1 + ". byt - " + prijmeni[i] + ", " + jmeno[i]);
            }

        }
       
    }
}
