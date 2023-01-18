using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte 1. číslo.");
            double a = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 2. číslo.");
            double b = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 3. číslo.");
            double c = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Zadejte 4. číslo.");
            double d = double.Parse(Console.ReadLine());

            Console.Clear();

            double max = 0;
            double min = 0;
            if (a >= b && a >= c && a >= d)
            {
                max = a;
            }
            else if (b >= c && b >= d && b >= a)
            {
                max = b;
            }
            else if (c >= d && c >= a && c >= b)
            {
                max = c;
            }
            else
            {
                max = d;
            }

            if (a <= b && a <= c && a <= d)
            {
                min = a;
            }
            else if (b <= c && b <= d && b <= a)
            {
                min = b;
            }
            else if (c <= d && c <= a && c <= b)
            {
                min = c;
            }
            else
            {
                min = d;
            }


            if ((max == a && b == min) || (max == b && a == min))
            {
                double mid0 = c;
                double mid1 = d;
                if (mid0>=mid1)
                {
                    double midmax = mid0;
                    double midmin = mid1;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
                else
                {
                    double midmax = mid1;
                    double midmin = mid0;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
            }
            else if ((max == a && c == min) || (max == c && a == min))
            {
                double mid0 = b;
                double mid1 = d;
                if (mid0>=mid1)
                {
                    double midmax = mid0;
                    double midmin = mid1;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
                else
                {
                    double midmax = mid1;
                    double midmin = mid0;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
            }
            else if ((max == a && d == min) || (max == d && a == min))
            {
                double mid0 = b;
                double mid1 = c;
                if (mid0 >= mid1)
                {
                    double midmax = mid0;
                    double midmin = mid1;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
                else
                {
                    double midmax = mid1;
                    double midmin = mid0;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }

            }
            else if ((max == b && c == min) || (max == c && b == min))
            {
                double mid0 = a;
                double mid1 = d;
                if (mid0 >= mid1)
                {
                    double midmax = mid0;
                    double midmin = mid1;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
                else
                {
                    double midmax = mid1;
                    double midmin = mid0;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }

            }
            else if ((max == b && d == min) || (max == d && b == min))
            {
                double mid0 = a;
                double mid1 = c;
                if (mid0 >= mid1)
                {
                    double midmax = mid0;
                    double midmin = mid1;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
                else
                {
                    double midmax = mid1;
                    double midmin = mid0;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }

            }
            else if ((max == c && d == min) || (max == d && c == min))
            {
                double mid0 = d;
                double mid1 = c;
                if (mid0 >= mid1)
                {
                    double midmax = mid0;
                    double midmin = mid1;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }
                else
                {
                    double midmax = mid1;
                    double midmin = mid0;
                    Console.WriteLine("Čísla seřazená vzestupně: {0}, {1}, {2}, {3}.", min, midmin, midmax, max);
                }

            }
        }
    }
}
