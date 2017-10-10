using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP08.SelectionIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //RecapActivity();

            //SimpleIfStatement();

            //IfElseIfExample();

            string username = string.Empty;
            string password = string.Empty;

            Console.WriteLine("Username:");
            username = Console.ReadLine();
            Console.WriteLine("Password:");
            password = Console.ReadLine();

            if (username == "andy")
            {
                if (password == "letmein")
                {
                    Console.WriteLine("Welcome user!");
                }
                else
                {
                    Console.WriteLine("ACCESS DENIED!");
                }
            }
            else
            {
                Console.WriteLine("ACCESS DENIED!");
            }

            if (username == "andy" && password == "letmein")
            { 
                Console.WriteLine("Welcome user!");
            }
            else
            {
                Console.WriteLine("ACCESS DENIED!");
            }
        }

        private static void IfElseIfExample()
        {
            int age = 0;

            Console.WriteLine("Please give me an age:");
            age = int.Parse(Console.ReadLine());

            if (age >= 65)
            {
                Console.WriteLine("Retired");
            }
            else if (age >= 35)
            {
                Console.WriteLine("Middle aged");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else if (age >= 13)
            {
                Console.WriteLine("Teen");
            }
            else if (age >= 4)
            {
                Console.WriteLine("Child");
            }
            else
            {
                Console.WriteLine("Toddler");
            }
        }

        private static void SimpleIfStatement()
        {
            string password = string.Empty;
            const string secretPassword = "AndyIsCool";

            Console.WriteLine("Please give me a password");
            password = Console.ReadLine();

            if (password == secretPassword)
            {
                Console.WriteLine("You're now logged in");
            }
            else
            {
                Console.WriteLine("That was incorrect");
            }
        }

        private static void RecapActivity()
        {
            // Function to make "Andy Wyatt" become "A.W."
            Console.WriteLine("Please give me your forename");
            string forename = Console.ReadLine();
            Console.WriteLine("Please give me your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Your initials are " + GetInitials(forename, surname));
        }

        private static string GetInitials(string forename, string surname)
        {
            string result = string.Empty;

            result = forename[0] + "." + surname[0] + ".";

            return result;
        }
    }
}
