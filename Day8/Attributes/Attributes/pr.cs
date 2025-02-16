using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class pr
    {
        public static void Main(string[] args)
        {
           /* GenericClass<int> intobj = new GenericClass<int>(10);
            int val = intobj.GenericMethod(200);
            Console.WriteLine(val);


            GenericClass<string> obj = new GenericClass<string>("isha");
            string valu = obj.GenericMethod("ghosh");
            Console.WriteLine(valu);*/

            GenericMethods obj=new GenericMethods();
            obj.GenericMethod<int, string>(10, "isha");
            obj.GenericMethod<int, int>(10, 20);
            Console.WriteLine(obj);

        }
    }



    /*
     
     
     */
}
