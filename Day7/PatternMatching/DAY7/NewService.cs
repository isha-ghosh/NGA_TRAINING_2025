using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    public static class NewService
    {
        //Extension Mthod
        public static void Test3(this OldService ser)   //Binding of a static method with a new class that method will become non static for OldService Class

        {



        }

        public static void Test4(this OldService ser, int x)

        {

            Console.WriteLine(x);

            Console.WriteLine(ser.x);

        }
    }
    
}
