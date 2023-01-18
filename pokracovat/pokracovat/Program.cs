using System;

namespace pokracovat
{
    class Program
    {
        static void Main(string[] args)
        {
            string odpoved;
            int cislo;
            string den;
            do
            {
                do
                {
                    //Console.WriteLine("Zadejte číslo dne...");
                    Console.WriteLine("Zadejte trojciferné číslo...");
                    cislo = int.Parse(Console.ReadLine());
                    if (cislo < 100 || cislo > 999)
                    {
                        // Console.WriteLine("Neexistuje " + cislo + ". den!");
                        Console.WriteLine("Toto není trojciferné číslo!");
                    }
                }
                while (cislo < 100 || cislo > 999);
                /*
                switch(cislo)
                {
                    case 1:
                        den = "pondělí";
                        break;
                    case 2:
                        den = "úterý";
                        break;
                    case 3:
                        den = "středa";
                        break;
                    case 4:
                        den = "čtvrtek";
                        break;
                    case 5:
                        den = "pátek";
                        break;
                    case 6:
                        den = "sobota";
                        break;
                    case 7:
                        den = "neděle";
                        break;
                    default:
                        den = "0";
                        break;
                }

                Console.WriteLine("Dnes je " + den + ". (Stiskněte jakoukoliv klávesu pro pokračování...)");
                Console.ReadKey();
                */
                Console.WriteLine(cislo);
                do
                {
                    Console.WriteLine("Chcete pokračovat? (Y/N)");
                    odpoved = Console.ReadLine().ToUpper();
                    if (odpoved != "Y" && odpoved != "N")
                    {
                        Console.WriteLine("Neplatná odpověď.");
                    }

                }
                while (odpoved != "N" && odpoved != "Y");
            }
            while (odpoved != "N");
            Console.Write("konec");
            Console.ReadKey();
        }
    }
}
