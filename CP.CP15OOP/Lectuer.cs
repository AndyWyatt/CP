using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP15OOP
{
    public class Lectuer : Person
    {
        public decimal Salery { get; private set; }

        public Lectuer(string forename,
            string surname,
            DateTime dob,
            decimal salery) : base(forename, surname, dob)
        {
            Salery = salery;
        }

        public void Teach()
        {

        }
    }
}
