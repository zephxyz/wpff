using System;

namespace new1
{
    internal class Program
{
    static void Main(string[] args)
    {
            int x;
            int y;
            int v;
            double spravne = 0;
            double chyba = 0;
            int check;
            bool z;
            bool correct;
            string odpoved = "A";
            string odpoved0;
            string odpoved1;
            Random xd = new Random();
            do
            {
                do
                {
                    Console.WriteLine("Vyberte, co chcete procvičovat... (Napište znak +,-,*,/) \nUkončení (Napište END)");
                    odpoved0 = Console.ReadLine().ToUpper();
                    if (odpoved0 != "*" && odpoved0 != "-" && odpoved0 != "+" && odpoved0 != "/" && odpoved0 != "..........end" && odpoved0 != "END")
                    {
                        Console.WriteLine("Napište jeden ze tří uvedených znaků!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (odpoved0 == "END")
                        odpoved = "";
                }
                while (odpoved0 != "*" && odpoved0 != "-" && odpoved0 != "+" && odpoved0 != "/" && odpoved0 != "END");

                while (odpoved0 == "*")
                {
                    Console.Clear();
                    x = xd.Next(1, 11);
                    y = xd.Next(1, 11);

                    do
                    {
                        Console.WriteLine($"{x}*{y} = ?");
                        z = int.TryParse(Console.ReadLine(), out check);
                        if (!z)
                            Console.WriteLine("Zadejte přirozené číslo!");


                    }
                    while (!z);

                    correct = (x * y) == check;
                    v = x * y;

                    if (correct)
                    {
                        Console.WriteLine("Správná odpověď!");
                        spravne++;
                    }
                    else
                    {
                        Console.WriteLine("Špatná odpověď! Správná odpověd je: " + v);
                        chyba++;
                    }



                    Console.WriteLine("Chcete změnit procvičování? A (Pokud ne, stiskněte klávesu 'Enter')");
                    odpoved1 = Console.ReadLine().ToUpper();
                    if (odpoved1 == "A")
                        odpoved0 = "..........end";
                    Console.Clear();

                }

                while (odpoved0 == "+")
                {
                    Console.Clear();
                    x = xd.Next(1, 101);
                    y = xd.Next(1, 101);

                    do
                    {
                        Console.WriteLine($"{x}+{y} = ?");
                        z = int.TryParse(Console.ReadLine(), out check);
                        if (!z)
                            Console.WriteLine("Zadejte přirozené číslo! Stiskněte jakoukoliv klávesu pro pokračování...");


                    }
                    while (!z);

                    correct = (x + y) == check;
                    v = x + y;

                    if (correct)
                    {
                        Console.WriteLine("Správná odpověď!");
                        spravne++;
                    }
                    else
                    {
                        Console.WriteLine("Špatná odpověď! Správná odpověd je: " + v);
                        chyba++;
                    }



                    Console.WriteLine("Chcete změnit procvičování? A (Pokud ne, stiskněte klávesu 'Enter')");
                    odpoved1 = Console.ReadLine().ToUpper();
                    if (odpoved1 == "A")
                        odpoved0 = "..........end";
                    Console.Clear();
                }

                while (odpoved0 == "-")
                {
                    Console.Clear();
                    x = xd.Next(1, 101);
                    y = xd.Next(1, 101);

                    do
                    {
                        Console.WriteLine($"{x}-{y} = ?");
                        z = int.TryParse(Console.ReadLine(), out check);
                        if (!z)
                            Console.WriteLine("Zadejte přirozené číslo! Stiskněte jakoukoliv klávesu pro pokračování...");


                    }
                    while (!z);

                    correct = (x - y) == check;
                    v = x - y;

                    if (correct)
                    {
                        Console.WriteLine("Správná odpověď!");
                        spravne++;
                    }
                    else
                    {
                        Console.WriteLine("Špatná odpověď! Správná odpověd je: " + v);
                        chyba++;
                    }



                    Console.WriteLine("Chcete změnit procvičování? A (Pokud ne, stiskněte klávesu 'Enter')");
                    odpoved1 = Console.ReadLine().ToUpper();
                    if (odpoved1 == "A")
                        odpoved0 = "..........end";
                    Console.Clear();
                }
                

                while (odpoved0 == "/")
                {
                    Console.Clear();
                    do
                    {
                        x = xd.Next(2, 1001);
                        y = xd.Next(2, 10);
                    }
                    while (x < y || x % y != 0);


                    do
                    {
                        Console.WriteLine($"{x}/{y} = ?");
                        z = int.TryParse(Console.ReadLine(), out check);
                        if (!z)
                            Console.WriteLine("Zadejte přirozené číslo!");


                    }
                    while (!z);

                    correct = (x / y) == check;
                    v = x / y;

                    if (correct)
                    {
                        Console.WriteLine("Správná odpověď!");
                        spravne++;
                    }
                    else
                    {
                        Console.WriteLine("Špatná odpověď! Správná odpověd je: " + v);
                        chyba++;
                    }



                    Console.WriteLine("Chcete změnit procvičování? A (Pokud ne, stiskněte klávesu 'Enter')");
                    odpoved1 = Console.ReadLine().ToUpper();
                    if (odpoved1 == "A")
                        odpoved0 = "..........end";
                    Console.Clear();
                }

            }
            while (odpoved == "A");

            double pr = spravne + chyba;
            double prspravne = (spravne/pr)*100;
            double prspatne = (chyba/pr)*100;
           
            Console.WriteLine("Správně - " + spravne + " ("+ prspravne +"%)\nŠpatně - " + chyba + " ("+ prspatne +"%)");
    }
}
}
