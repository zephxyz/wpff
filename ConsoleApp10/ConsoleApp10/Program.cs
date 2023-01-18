using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int times = 10;
            int i = 0;
            do
            {
                Console.WriteLine(times);
                times--;
            }
            while (times != 0);*/
            int times;
            bool ctrl;
            do
            {
                ctrl = int.TryParse(Console.ReadLine(), out times);
            }
            while (!ctrl);

            for (int i = 0; i <= times; i++)
                Console.WriteLine(i);
            Console.WriteLine("Start");
        }
    }
}
