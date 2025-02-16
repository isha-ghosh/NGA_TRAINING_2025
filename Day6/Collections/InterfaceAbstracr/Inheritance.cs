using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstracr
{
    
        interface IHR
        {
            void lastDrawn();
        }

        abstract class AbsClass
        {
            private string panNumber;
            private double basicSalary;

            public string PanNumber
            {
                get { return panNumber; }
                set { panNumber = value; }
            }

            public double BasicSalary
            {
                set { basicSalary = value; }
            }

            public abstract void PanDetails();

            public void BasicPay()
            {
                Console.WriteLine($"Basic Pay: {basicSalary}");
            }
        }
    
}
