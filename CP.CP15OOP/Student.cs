using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP15OOP
{
    public class Student : Person
    {
        public bool IsEnrolled { get; set; }
        
        public Student(string forename,
            string surname,
            DateTime dob) : base(forename, surname, dob)
        {

        }

        public Assignment DoGroupWork(Student[] students)
        {
            Assignment result = null;

            Console.WriteLine("DOING GROUP WORK!");

            return result;
        }

        public override void DoWork()
        {
            Console.WriteLine("I'm working on my assignment");
        }
    }
}
