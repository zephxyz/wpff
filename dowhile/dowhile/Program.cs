using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Zadej počet sudých čísel.");

            do
            {
                Console.WriteLine("Zadejte 1. číslo. (2 sudá, 1 liché)");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)

                Console.WriteLine("Zadejte 2. číslo. (2 sudá, 1 liché)");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Zadejte 3. číslo. (2 sudá, 1 liché)");
                c = int.Parse(Console.ReadLine());

            }
            while ((a % 2 == 0 && b % 2 == 0 && c % 2 == 0) || (a % 2 != 0 && b % 2 != 0) || (a % 2 != 0 && c % 2 != 0) || (b % 2 != 0 && c % 2 != 0));
            

            Console.WriteLine("Zadaná čísla: " + a + ", " + b + ", " + c);
        }
    }
}
