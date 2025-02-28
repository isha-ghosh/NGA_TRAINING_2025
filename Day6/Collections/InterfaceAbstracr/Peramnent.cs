using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstracr
{
    
        class PermanentEmployee : AbsClass, IHR
        {
            public void lastDrawn()
            {
                Console.WriteLine("Last drawn salary of Permanent Employee.");
            }

            public override void PanDetails()
            {
                Console.WriteLine($"Permanent Employee PAN: {PanNumber}");
            }
        }


        
    
}
