using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 999;
            int b = 4;
            int c = 5;
            if ((a+b) > c)
            {
                if((a+c) > b) 
                {
                    if ((b+c) > a)
                    {
                        Console.WriteLine("Trojúhelník");
                    }
                    else
                    {
                        Console.WriteLine("Není");
                    }
                }
                else 
                {
                    Console.WriteLine("Není");
                }
            }
            else 
            {
                Console.WriteLine("Není");
            }
        }
    }
}
