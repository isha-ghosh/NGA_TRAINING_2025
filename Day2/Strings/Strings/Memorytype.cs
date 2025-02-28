using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Memorytype
    {
        public string Name;
        public static void Memoryyy(string[] args)
        {

            //value type
            int a = 10;
            int b = 20;



            b = 20;

            Console.WriteLine($"a= {a} , b= {b}");


            //reference type
            Memorytype e = new Memorytype();
            e.Name = "CSharp";

            Memorytype e1 = e;
            e1.Name = "Java";
            Console.WriteLine(e.Name);
        }
    }
}
