using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pl;
            int ai;
            int celkem = 0;
            int skorepl = 0;
            int skoreai = 0;
            string odpoved;
            int y = 1000000;
            do
            {
                Console.WriteLine("Hoď kostkou. (Stiskněte jakékoliv tlačítko.)");
                // Console.ReadKey();
                Random x = new Random();
                pl = x.Next(1, 7);
                ai = x.Next(1, 7);

                if (pl > ai)
                {
                    skorepl++;
                    celkem++;
                    Console.WriteLine("Vyhrál jsi. " + pl + ":" + ai + "   Skóre: Hráč " + skorepl + ":" + skoreai + " Počítač");
                }
                else if (pl < ai)
                {
                    skoreai++;
                    celkem++;
                    Console.WriteLine("Prohrál jsi. " + pl + ":" + ai + "   Skóre: Hráč " + skorepl + ":" + skoreai + " Počítač");
                }
                else
                {
                    skorepl++;
                    skoreai++;
                    celkem++;
                    Console.WriteLine("Remíza! " + pl + ":" + ai + "   Skóre: Hráč " + skorepl + ":" + skoreai + " Počítač");
                }

                /*
                do
                {
                    Console.WriteLine("Chcete pokračovat? A/N");
                    odpoved = Console.ReadLine().ToUpper();
                    if (odpoved != "A" && odpoved != "N")
                        Console.WriteLine("Neplatná odpověď!");
                }
                while (odpoved != "A" && odpoved != "N");
                */
                y--;
            }
            while (y > 0);

        }
    }
}
