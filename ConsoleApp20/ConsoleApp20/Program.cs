using System;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            int[] pole = new int[10];

            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = RNG.Next(-10, 11);
            }
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < 0)
                Console.Write(pole[i] + " ");
            }
        }
    }
}
