using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stiskněte jakoukoliv klávesu pro start...");
            Console.ReadKey();

            Console.Clear();

            int pole = 1;
            Random xd = new Random();
            int krok;
            int hod = 0;
            do
            {
                krok = xd.Next(1, 7);
                pole = pole + krok;
                if (pole % 13 == 0)
                    pole = pole - 12;
                else if (pole % 11 == 0)
                    pole = pole + 10;
                hod++;
                Console.WriteLine("Pole po " + hod + ". hodu: " + pole);
            }
            while (pole < 100);

            Console.WriteLine("Do cíle se počítač dostal za " + hod + " hodů.");
        }
    }
}
