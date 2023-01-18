using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte den narození.");
            int den = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte měsíc narození.");
            int mesic = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte rok narození.");
            int rok = int.Parse(Console.ReadLine());

            Console.Clear();

            int datumd = 9;
            int datumm = 10;
            int datumr = 2021;

            if ((datumr - rok) > 18)
            {
                Console.WriteLine("Mohli jste se účastnit voleb");
            }
            else if ((datumr - rok) == 18)
            {
                if (datumm>mesic)
                {
                    Console.WriteLine("Mohli jste se účastnit voleb");
                }
                else if (datumm<mesic)
                {
                    Console.WriteLine("Ještě vám nebylo 18, nemohli jste se účastnit voleb.");
                }
                else if (datumm==mesic)
                {
                    if (datumd>=den)
                    {
                        Console.WriteLine("Mohli jste se účastnit voleb");
                    }
                    else if (datumd<den)
                    {
                        Console.WriteLine("Ještě vám nebylo 18, nemohli jste se účastnit voleb.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ještě vám nebylo 18, nemohli jste se účastnit voleb.");
            }

        }
    }
}
