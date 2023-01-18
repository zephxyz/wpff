using System;

namespace den
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo dne (1-7).");
            int d = int.Parse(Console.ReadLine());

            if (d == 1)
                Console.WriteLine("Dnes je pondělí.");
            else if (d == 2)
                Console.WriteLine("Dnes je úterý.");
            else if (d == 3)
                Console.WriteLine("Dnes je středa.");
            else if (d == 4)
                Console.WriteLine("Dnes je čtvrtek.");
            else if (d == 5)
                Console.WriteLine("Dnes je pátek.");
            else if (d == 6)
                Console.WriteLine("Dnes je sobota.");
            else if (d == 7)
                Console.WriteLine("Dnes je neděle.");
            else
                Console.WriteLine(d + ". den neexistuje.");
        }
    }
}
