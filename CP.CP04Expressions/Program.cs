using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP04Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //StartOfLesson();

            //CallingFunctionsExamples();

            PrimaryOperators();

            PrefixIncrement();

            int age = 20;
            age = ++age + age++; // ?? <- Don't write code like this just to look good.
        }

        private static void PrefixIncrement()
        {
            int age = 20;
            // prefix increment
            Console.WriteLine("My age is " + ++age);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("My age is " + --age);
            Console.WriteLine("My age is " + age);
        }

        private static void PrimaryOperators()
        {
            int calc = 2 + 2 * 2;
            Console.WriteLine(calc);

            // With brackets
            calc = (2 + 2) * 2;
            Console.WriteLine(calc);

            // Dot operator
            Console.WriteLine("Pi = " + Math.PI); // <- Notice the dot
            Console.WriteLine("Machine name = " + Environment.MachineName);

            // Function invocation f()
            Console.WriteLine("2 + 2 = " + Add(2, 2));

            int age = 20;
            // postfix increment
            Console.WriteLine("My age is " + age++);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("My age is " + age--);
            Console.WriteLine("My age is " + age);
        }

        private static void CallingFunctionsExamples()
        {
            Console.WriteLine("2 + 2 = " + (2 + 2));
            Console.WriteLine("2 + 2 = " + Add(2, 2));
            Console.WriteLine("4 + 4 = " + (4 + 4));
            Console.WriteLine("4 + 4 = " + Add(4, 4));

            Console.WriteLine("4 * 4 = " + Mulitply(4, 4)); // 2 Arguments 4 & 4

            Console.WriteLine("My full name = " + GetFullname("Andy", "Wyatt"));

            string forename;
            string surname;
            string fullname;

            Console.WriteLine("What is your forename?");
            forename = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            surname = Console.ReadLine();

            fullname = GetFullname(forename, surname);

            Console.WriteLine("Your full name = " + fullname);
        }

        private static string GetFullname(string forename, string surname)
        {
            string result = string.Empty;

            result = forename + " " + surname;

            return result;
        }

        // Function or procedure or more accurately method.
        private static int Add(int num1, int num2) // 2 Parameters num1 & num2
        {
            int result = 0;

            result = num1 + num2;

            return result;
        }

        private static int Mulitply(int num1, int num2) // 2 Parameters num1 & num2
        {
            int result = 0;

            result = num1 * num2;

            return result;
        }

        private static void StartOfLesson()
        {
            // This is a statement
            Console.WriteLine("Hello World!");

            // These two lines are one statement
            Console.WriteLine("Hello world this" +
                " program is made by Andy");

            // Many expression in the following statement
            // 1) 2 + 2
            // 2) (2 + 2)
            // 3) "2 + 2 = " + (2 + 2) <- Left side + right side
            // 4) ("2 + 2 = " + (2 + 2))
            // 5) Console.WriteLine(everyting that is in the brackets);
            Console.WriteLine("2 + 2 = " + (2 + 2));

            // Variables can variably change
            int age = 17;
            age = age + 1;

            char initial = 'l';
            initial = 'L';

            double height = 178.0;
            height = height - 100.0;

            // constants can not be changed
            const double PI = 3.14159265359;
            // PI = 3.4; <- This will cause an error because we're not allowed to change it
            const int noOfPlanetsInOurSolorSystem = 8;
            //noOfPlanetsInOurSolorSystem = 9;

            // Get total cost of item code
            // declearation
            const decimal costOfItem = 5.50m;
            int totalItems;
            decimal totalCost;

            // input
            Console.WriteLine("How many of the items do you want?" +
                " They're £5.50 each");
            totalItems = int.Parse(Console.ReadLine());

            // processing
            totalCost = totalItems * costOfItem;

            // output
            Console.WriteLine("Total cost = " + totalCost.ToString("C"));
        }
    }
}
