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

        private Lectuer(string forename,
            string surname,
            DateTime dob) : base(forename, surname, dob)
        {

        }

        public void Teach()
        {

        }
    }
}
