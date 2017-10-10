using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP14IterationPostCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountingTo10Example();

            AskForAgeWithValidation();
        }

        private static void AskForAgeWithValidation()
        {
            bool error = false;
            int age = 0;
            do
            {
                Console.Write("Please enter age: ");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (age >= 0 && age <= 100)
                    {
                        error = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid age.");
                        error = true;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number.");
                    error = true;
                }
            } while (error);
        }

        private static void CountingTo10Example()
        {
            int i = 1;
            do
            {
                Console.WriteLine("The value of i is " + i);
                i++;
            } while (i <= 10);
        }
    }
}
