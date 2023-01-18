using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadávej přirozená čísla, vypočítám kolik jich je sudých, lichých \nVložením 0 nebo záporného čísla sčítání ukončíš.");
            int a;
            int x = 0;
            int y = 0;
            string konec = "N";
            int celkem = 0;
            int b;
            Random xd = new Random();
            do
            {
                Console.WriteLine("Zadejte hodní mez generátoru.");
                b = int.Parse(Console.ReadLine());
                if (b < 0)
                    Console.WriteLine("Zadejte kladné číslo!");
                else
                    b++;
            }
            while (b < 0);



            do
            {
                a = xd.Next(0, b);
                Console.WriteLine(a);
                if (a <= 0)
                    konec = "A";
                else if (a % 2 == 0)
                    x++;
                else if (a % 2 == 1)
                    y++;
                celkem++;
            }
            while (konec != "A");
            Console.WriteLine($"Vygenerovalo se celkem {celkem} čísel, z toho bylo {x} sudých a {y} lichých.");
        }
    }
}
