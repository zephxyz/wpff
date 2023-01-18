using System;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int[] nr = new int[10];
            bool check = true;
            int u;
            int r = 0;
            int ct = 0;
            

            do
            {
                
                for (int i = 0; i < nr.Length; i++)
                {
                    r = rng.Next(1, 11);
                    if (nr[i] == r)
                        check = false;
                }
                if (check)
                {
                    nr[ct] = r;
                    ct++;
                }

            }
            while (ct < nr.Length);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(nr[i] + " | ");
            }
            Console.ReadKey();
            
        }
    }
}
