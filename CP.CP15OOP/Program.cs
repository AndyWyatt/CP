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
            //InheritanceScenario();

            //PolymorphismScenario();

            Device[] devices = new Device[]
            {
                new Tablet("Tab1", 10.0, 1),
                new Tablet("Tab2", 20.0, 2),
                new PC("PC1", 100.0, 3),
                new PC("PC2", 150.0, 4)
            };

            foreach (Device device in devices)
            {
                device.SwitchOff();
                Console.WriteLine();
            }
        }

        private static void PolymorphismScenario()
        {
            Person[] people = new Person[]
            {
                new Person("Dorris", "Jones", DateTime.Now.AddYears(-120)),
                new Student("Oliver", "Bond", DateTime.Now.AddYears(-17)),
                new Student("Kyle", "Fardoe-Walker", DateTime.Now.AddYears(-18)),
                new Lectuer("Andy", "Wyatt", DateTime.Now.AddYears(-37), 20000.00m),
                new Lectuer("Jacqui", "Maw", DateTime.Now.AddYears(-45), 21000.00m)
            };

            foreach (Person person in people)
            {
                if (person is Lectuer)
                {
                    Console.WriteLine("I'm a teacher");
                    Lectuer     lecturer = person as Lectuer; // Preferred
                                lecturer = (Lectuer)person; // Unpreferred
                    lecturer.Teach();
                }
                else if (person is Student)
                {
                    Console.WriteLine("I'm a student");
                    Student student = person as Student;
                    student.DoGroupWork(null);
                }
                Console.WriteLine(person.Forename + " " + person.Surname);
                person.DoWork();
                Console.WriteLine();
            }
        }

        private static void InheritanceScenario()
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
