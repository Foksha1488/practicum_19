using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a1 = 1;
            int d = 4;


            for (int i = 1; i <= 5; i++)
            {
                int an = a1 + (i - 1) * d;
                Console.Write(an + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
