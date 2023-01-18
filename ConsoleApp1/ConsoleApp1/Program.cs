using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Kolik jste dostal % z testu?");
             double procent = double.Parse(Console.ReadLine());
             int znamka = 0;
             string hod = "error";

             if (procent > 100 || procent < 0)
                 Console.WriteLine($"Výsledek {procent} neumím vyhodnotit");
             else
             {
                 if (procent < 33)
                     (znamka,hod) = (5, "nedostatečně");
                 else if (procent < 50)
                     (znamka, hod) = (4, "dostatečně");
                 else if (procent < 67)
                     (znamka, hod) = (3, "dobře");
                 else if (procent < 83)
                     (znamka, hod) = (2, "chvalitebně");
                 else if (procent <= 100)
                     (znamka, hod) = (1, "výborně");
                 Console.WriteLine("Jestliže máte {0}% dostali jste známku {1} - {2}.", procent, znamka, hod);
             }*/
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double e = 0;
            double p;
            Console.WriteLine("Kolik máte testů?");
            int test = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Počet %?");
                p = double.Parse(Console.ReadLine());

                while (p < 0 || p > 100)
                {
                    Console.WriteLine("Počet %?");
                    p = double.Parse(Console.ReadLine());
                }

                if (p < 33)
                    e++;
                else if (p < 50)
                    d++;
                else if (p < 67)
                    c++;
                else if (p < 83)
                    b++;
                else if (p <= 100)
                    a++;
                test--;
            }
            while (test > 0);

            double prumer = (a + b * 2 + c * 3 + d * 4 + e * 5) / (a + b + c + d + e);
            string hod = "o";
            double prumerz = Math.Round(prumer);
           switch(prumerz)
            {
                case 1:
                    hod = "výborně";
                    break;
                case 2:
                    hod = "chvalitebně";
                    break;
                case 3:
                    hod = "dobře";
                    break;
                case 4:
                    hod = "dostatečně";
                    break;
                case 5:
                    hod = "nedostatečně";
                    break;
            }

            Console.WriteLine("Průměr známek z testů je: " + prumer + " - " + hod);
        }
    }
}
