using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej libovolný text");
            string text = Console.ReadLine();
            
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    continue;
                Console.Write(text[i]);
            }
            
        }                    
    }
}
