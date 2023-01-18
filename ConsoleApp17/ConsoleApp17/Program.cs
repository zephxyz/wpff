using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej libovolný text");
            string text = Console.ReadLine();
            string output = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - 1)
                    output = output + text[i] + "/";
                else
                    output = output + text[i];
            }
            Console.WriteLine(output);
        }
    }
}
