using System;

namespace nvm
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double d;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            double clk = a + b + c + d;

            double ap = a / clk;
            double bp = b / clk;
            double cp = c / clk;
            double dp = d / clk;

            double zkouska = ap + bp + cp + dp;

            ap = Math.Round(ap, 3);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", ap, bp, cp, dp, zkouska, clk);
        }
    }
}
