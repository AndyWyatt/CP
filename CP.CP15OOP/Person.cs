using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP15OOP
{
    public class Person
    {
        public int No { get; private set; }
        public string Forename { get; private set; }
        public string Surname { get; private set; }
        public DateTime DOB { get; private set; }
        public double HeightInCM { get; set; }
        public char GenderCode { get; set; }
        public DayOfWeek[] DaysInCollege { get; set; }

        private Person()
        {

        }

        public Person(string forename,
            string surname,
            DateTime dob) : this()
        {
            Forename = forename;
            Surname = surname;
            DOB = dob;
        }

        public void DoWork()
        {

        }

        public void GoToRoom(string roomNo)
        {

        }

        public string FindFactsOfInternet(string topic)
        {
            string result = string.Empty;

            return result;
        }
    }
}
