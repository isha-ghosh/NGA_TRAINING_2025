using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstracr
{
    namespace EmployeeActivity
    {
        class Program
        {
            static void Main()
            {
                PermanentEmployee p = new PermanentEmployee();
                p.PanNumber = "ABCDE1234F";
                p.BasicSalary = 50000;
                p.lastDrawn();
                p.PanDetails();
                p.BasicPay();

                Console.WriteLine("********************************************");

                ContractualEmployee c = new ContractualEmployee();
                c.PanNumber = "XYZ9876P";
                c.BasicSalary = 30000;
                c.lastDrawn();
                c.PanDetails();
                c.BasicPay();
            }
        }


    }
}
