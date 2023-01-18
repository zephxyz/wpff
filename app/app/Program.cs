using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            int cislo;
            int pokus = 0;
            do
            {
                
                
                    Random kostka = new Random();
                    cislo = kostka.Next(-100, 2);
                    
                               
                
                Console.WriteLine(cislo);
                pokus++;
            }
            while (cislo < 0);

            Console.WriteLine(pokus + " pokusů");
        }
    }
}
