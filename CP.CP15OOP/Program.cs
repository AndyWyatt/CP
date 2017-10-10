using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP15OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student andy = new Student(
                "Andy",
                "Wyatt",
                new DateTime(2005, 7, 9));
            andy.HeightInCM = 120.0;

            Student dave = new Student(
                "Dave",
                "Newbold",
                new DateTime(2005, 1, 1));
            dave.HeightInCM = 20.0;

            Student carl = new Student(
                "Carl",
                "Newton",
                new DateTime(1995, 1, 2));
            carl.IsEnrolled = true;

            Console.WriteLine(andy.Forename + " " + andy.Surname + " " + andy.IsEnrolled);
            Console.WriteLine(dave.Forename + " " + dave.Surname + " " + dave.IsEnrolled);
            Console.WriteLine(carl.Forename + " " + carl.Surname + " " + carl.IsEnrolled);

            Lectuer andy2 = new Lectuer("Andy", "Wyatt", new DateTime(1980, 8, 2), 10.0m);
            Console.WriteLine(andy2.Forename + " " + andy2.Surname + " " + andy2.Salery);

            andy2.HeightInCM = 100.0;
            andy.HeightInCM = 80.0;
        }
    }
}
