using System;

namespace frl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napište libovolný text.");
            string text = Console.ReadLine();
            char pismeno;
            Console.WriteLine("Zadaný text obsahuje " + text.Length + " znaků.");
            for (int i = 0; i < text.Length; i++)
            {
                pismeno = text[i];
                Console.WriteLine(i+1 + " " + pismeno);
            }           
        }
    }
}