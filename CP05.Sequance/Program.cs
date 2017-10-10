using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP05.Sequance
{
    class Program
    {
        static void Main(string[] args)
        {
            //APRCalcInterface();

            int a = 10 * 10; // Make a equal to 100
            int b = 100 / 10; // Make b equal to 10
            int c = 90 % 60; // Remainder.  What is the remainder of 90 / 60 -> 30

            int d = 5 + 5; // Makes d equal to 10
            int e = 5 - 5; // Makes d equal to 0

            int f = 5 / 2; // 2
            double g = 5.0 / 2.0; // 2.5
            double h = 5.0 / 2.0; // 2.5

            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
        }

        private static void APRCalcInterface()
        {
            // declaration
            decimal cost = 0.0m;
            decimal apr = 0.0m;
            decimal answer = 0.0m;

            // input
            Console.WriteLine("Please give me the cost:");
            cost = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please give me the APR:");
            apr = decimal.Parse(Console.ReadLine());

            // processing
            answer = GetMonthlyCharge(cost, apr);

            // output
            Console.WriteLine("The charge monthly will be " + answer.ToString("C"));
        }

        private static decimal GetMonthlyCharge(decimal cost, decimal apr)
        {
            decimal result = 0.0m;

            result = cost * apr / 12.0m;

            return result;
        }
    }
}
