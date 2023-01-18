using System;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] xd = new int[20];
            Random rng = new Random();
            for (int i = 0; i < 20; i++)
            {
                xd[i] = rng.Next(0, 10);
                Console.WriteLine(xd[i]);
            }

            int min = xd[0];
            int minpocet = 0;
            int[] mininf = new int[20];
            
            int u = 0;
            for (int i = 0; i < 20; i++)
            {
                if (xd[i] < min)
                {
                    min = xd[i];
                    
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (min == xd[i])
                {
                    mininf[u] = i;
                    u++;
                }
            }
            int minfirst = 20;
            int minlast = 0;
            
            for (int i = 0; i < 20; i++)
            {
                if (minfirst > mininf[i])
                    minfirst = mininf[i];
            }
            for (int i = 0; i < 20; i++)
            {
                if (minlast < mininf[i])
                    minlast = mininf[i];
            }

            Console.WriteLine(minfirst + "" + minlast);
        }
    }
}
