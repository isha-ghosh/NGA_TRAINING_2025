using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstracr
{
    class ContractualEmployee : AbsClass, IHR
    {
        public void lastDrawn()
        {
            Console.WriteLine("Last drawn salary of Contractual Employee.");
        }

        public override void PanDetails()
        {
            Console.WriteLine($"Contractual Employee PAN: {PanNumber}");
        }
    }
}
