using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initialSavings =100;
            double monthlyIncrease =50;
            int numberOfMonths =10;
            double totalSavings =0;

            for (int i = 0; i < numberOfMonths; i++)
            {
                totalSavings += initialSavings + i * monthlyIncrease;
            }

            Console.WriteLine($"total amount{numberOfMonths}Montch:{totalSavings}");
            Console.ReadKey();
        }
    }
}
