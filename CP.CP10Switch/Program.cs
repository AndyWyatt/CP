using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP10Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertTheDayCodeIntoDayName();
        }

        private static void ConvertTheDayCodeIntoDayName()
        {
            string dayCode;

            Console.WriteLine("Please give me a day code:");
            dayCode = Console.ReadLine().ToLower();

            switch (dayCode)
            {
                case "1":
                case "m":
                case "mon":
                case "monday":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                case "tue":
                case "tuesday":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                case "w":
                case "wed":
                case "wednesday":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                case "thu":
                case "thur":
                case "thurs":
                case "thursday":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                case "f":
                case "fri":
                case "friday":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                case "sat":
                case "saturday":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                case "sun":
                case "sunday":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("That was an invalid code!");
                    break;
            }

            if (dayCode == "1" ||
                dayCode == "m" ||
                dayCode == "mon" ||
                dayCode == "monday")
            {
                Console.WriteLine("Monday");
            }

            //int age = 18;
            //if (age > 65)
            //{
            //    Console.WriteLine("Retired");
            //}
            //else if (age > 35)
            //{
            //    Console.WriteLine("Midle Aged");
            //}
            //else if (age > 18)
            //{
            //    Console.WriteLine("Adult");
            //}

            //switch (age)
            //{
            //    case 120:
            //    case 119:
            //    case 118:
            //    case 117:
            //    case 116:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //    case 120:
            //        Console.WriteLine("Retired");
            //}
        }
    }
}
