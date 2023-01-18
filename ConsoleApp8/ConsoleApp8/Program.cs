using System;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] pole = new int[3];  //int.Parse(Console.ReadLine())];

            bool z;
            string x = "0";
            int c = 0;
            int xy;

            z = int.TryParse(Console.ReadLine(), out pole[0]);
            z = int.TryParse(Console.ReadLine(), out pole[1]);
            z = int.TryParse(Console.ReadLine(), out pole[2]);
            Console.WriteLine(+pole[0] + "" + pole[1] + "" + pole[2]);

            do
            {
                if (pole[int.Parse(x)] == 0)
                {
                    c++;
                }
                xy = int.Parse(x);
                xy++;
                x = Convert.ToString(xy);

                Console.WriteLine("První dva stejné, třetí je počet čísel s hodnotou 0");
                Console.WriteLine(x);
                Console.WriteLine(xy);
                Console.WriteLine(c);
            }
            while (xy < 3);

           
        }
    }
}
