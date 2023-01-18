using System;

namespace guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int low;
            int high;
            // int guess;
            int userguess;
            int pokus;
            bool check;
            bool end = false;
            string continuee;
            Random xd = new Random();

            do
            {
                Console.Clear();

                pokus = 0;

                do
                {
                    x = xd.Next(1, 101);
                    y = xd.Next(1, 101);
                }
                while (x + 1 == y || x == y || y + 1 == x);

                if (x < y)
                {
                    low = x;
                    high = y;
                }
                else
                {
                    low = y;
                    high = x;
                }


                //guess = xd.Next(low, high);

                do
                {

                    pokus++;

                    Console.WriteLine("Hádejte číslo v intervalu. (" + pokus + ". pokus)");
                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out userguess);
                        if (!check)
                            Console.WriteLine("Zadejte přirozené číslo!");
                    }
                    while (!check);

                    if (userguess < low)
                        Console.WriteLine("Zadané číslo je menší než dolní mez!");
                    else if (userguess > high)
                        Console.WriteLine("Zadané číslo je větší než horní mez!");
                    /*else if (userguess < guess)
                        Console.WriteLine("Zadané číslo je v mezi a je menší než moje číslo.");
                    else if (userguess > guess)
                        Console.WriteLine("Zadané číslo je v mezi a je větší než moje číslo.");*/
                }
                while (userguess < low || userguess > high);

                //Console.WriteLine("Uhádl jste moje číslo (" + guess + ") na " + pokus + ". pokus.");

                Console.WriteLine("Uhádl jste číslo intervalu na " + pokus + ". pokus.");

                do
                {
                    Console.WriteLine("Chcete znova hádat? A");
                    continuee = Console.ReadLine().ToUpper();
                    if (continuee != "A")
                        end = true;
                    if (continuee == "")
                        end = false;
                }
                while (continuee == "");
                
                
            }
            while (!end);


        }
    }
}
