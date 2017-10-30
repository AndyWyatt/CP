using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP.CP24Collections
{
    class Plane
    {
        public string PilotName { get; set; }
        public int PortNo { get; set; }

        private Plane()
        {

        }

        public Plane(string pilotName, int portNo) : this()
        {
            PilotName = pilotName;
            PortNo = portNo;
        }

        public override string ToString()
        {
            return $"Plane - {PilotName} Port = {PortNo}";
        }
    }
}
