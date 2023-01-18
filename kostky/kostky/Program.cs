using System;

namespace kostky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolikrát chcete hodit dvěmi kostkami? (Pokud více jak 10mil, vyhodnocování bude trvat dlouhou dobu.)");
            string pocet0 = Console.ReadLine();
            int pocet = int.Parse(pocet0);
            double pocetdltl = double.Parse(pocet0);


            Console.WriteLine("Stiskni jakoukoli klávesu pro začátek.");
            Console.ReadKey();
            
            int a = 1;
            int b = 7;
            

            
            
            double q = 0; // 2
            double w = 0; // 3
            double e = 0; // 4
            double r = 0; // 5
            double t = 0; // 6
            double y = 0; // 7
            double u = 0; // 8
            double i = 0; // 9
            double o = 0; // 10
            double p = 0; // 11
            double x = 0; // 12

            double dltl = pocetdltl / 100;

        
            do
            {
                Random nh = new Random();
                int jedna = nh.Next(a, b);
                int dva = nh.Next(a, b);
                int clk = jedna + dva;

                if (clk == 2)
                    q++;
                else if (clk == 3)
                    w++;
                else if (clk == 4)
                    e++;
                else if (clk == 5)
                    r++;
                else if (clk == 6)
                    t++;
                else if (clk == 7)
                    y++;
                else if (clk == 8)
                    u++;
                else if (clk == 9)
                    i++;
                else if (clk == 10)
                    o++;
                else if (clk == 11)
                    p++;
                else
                    x++;
                if (clk >= 10)
                    Console.WriteLine($"{jedna} + {dva} = {clk}         {pocet} zbývá");
                
                else
                    Console.WriteLine($"{jedna} + {dva} = {clk}          {pocet} zbývá");

                pocet--;



            }
            while (pocet != 0);

            
                double vq = q / dltl;
                double vw = w / dltl;
                double ve = e / dltl;
                double vr = r / dltl;
                double vt = t / dltl;
                double vy = y / dltl;
                double vu = u / dltl;
                double vi = i / dltl;
                double vo = o / dltl;
                double vp = p / dltl;
                double vx = x / dltl;
            string kontrola = "x";

            double vv = vq + vw + ve + vr + vt + vy + vu + vi + vo + vp + vx;
            if (vv == 100)
                kontrola = "100";
            else
                kontrola = Convert.ToString(vv);
            Console.WriteLine("Kontrola = " + kontrola);

            Console.WriteLine($"2 - {vq}%|3 - {vw}%|4 - {ve}%|5 - {vr}%|6 - {vt}%|7 - {vy}%|8 - {vu}%|9 - {vi}%|10 - {vo}%|11 - {vp}%|12 - {vx}%");
            
        }
    }
}
