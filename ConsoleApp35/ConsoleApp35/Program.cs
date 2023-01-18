using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // File.WriteAllText("pokus.txt", Console.ReadLine());
            //try
            //{
            //    string rt = File.ReadAllText("pokuss.txt");
            //    Console.WriteLine(rt);

            //}
            //catch
            //{
            //    Console.WriteLine("");
            //}
            //Console.ReadKey();

            using (Stream str = new FileStream("pokuss.txt", FileMode.Open, FileAccess.ReadWrite))
            {
                using (StreamReader r = new StreamReader(str, Encoding.UTF8))
                {
                    r.ReadLine();
                }
            }
        }
    }
}
