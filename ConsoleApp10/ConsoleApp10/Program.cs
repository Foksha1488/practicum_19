using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = 200;
            double d = 0.2;
            int n = 150;


            double sum = n / 2.0 * (2 * a1 + (n - 1) * d);

            Console.WriteLine($"the sum of the first {n} arifmetic progress: {sum}");
            Console.ReadKey();
        }
    }
}
