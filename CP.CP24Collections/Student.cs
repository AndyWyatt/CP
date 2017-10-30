using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP24Collections
{
    public class Student
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public bool IsVaccinated { get; private set; } = false;

        private Student()
        {

        }

        public Student(string forename, string surname) : this()
        {
            Forename = forename;
            Surname = surname;
        }

        public void Vacinate()
        {
            IsVaccinated = true;
        }

        public override string ToString()
        {
            return $"Student - {Forename} {Surname} Vaccinated = {IsVaccinated}";
        }
    }
}
