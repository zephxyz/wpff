using System;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            bool kontrola;
            do
            {
                kontrola = int.TryParse(Console.ReadLine(), out cislo);
                Console.WriteLine(kontrola);
                Console.WriteLine(cislo);

            } 
            while (!kontrola);


            Console.WriteLine("jdgnkjdsngkdsngds");
            switch (cislo)
                {
                case 1:
                    Console.WriteLine("nigga");
                    break;
                default:
                    Console.WriteLine("normal");
                    break;
            }
        }
    }
}
