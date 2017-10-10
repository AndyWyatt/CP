using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP08IterationPreConditionalLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExample();

            //AverageAgeCalcaulator();

            int i = 1;
            while (i >= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        private static void AverageAgeCalcaulator()
        {
            int inputtedAge;
            int totalAges = 0;
            double averageAge;
            int numberOfAges = 0;

            Console.Write("Age? (-1 to exit) ");
            inputtedAge = int.Parse(Console.ReadLine());
            while (inputtedAge != -1)
            {
                if (inputtedAge >= 0 && inputtedAge <= 120)
                {
                    totalAges = totalAges + inputtedAge;
                    numberOfAges++;
                }
                else
                {
                    Console.WriteLine("Invalid age!");
                }

                Console.Write("Age? (-1 to exit) ");
                inputtedAge = int.Parse(Console.ReadLine());
            }

            averageAge = (double)totalAges / (double)numberOfAges;
            Console.WriteLine("AVG age = " + averageAge);
        }

        private static void FirstExample()
        {
            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine("The value of i is " + i);
                i++;
            }
        }
    }
}
