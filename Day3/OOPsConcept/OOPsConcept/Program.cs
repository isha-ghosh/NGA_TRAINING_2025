using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    internal class Program
    {

        class Test

        {
            int i, a;
            string s;
            bool b;

            //No args based constructor
            public Test()
            {
                Console.WriteLine("Constructor defined Explicitly");
                Console.WriteLine(i);

            }
            // args based constructor
            public Test(int a, int b)
            {
                Console.WriteLine("Constructor defined Explicitly");

                this.a = a;
                Console.WriteLine($"The value of a local variable : {a} ");
                Console.WriteLine(this.a); //this keyword resolves the ambiguity between the instance variable and local variable
            }
            public static void Maiiiin(string[] args)
            {
                Test t = new Test();
                Test t1 = new Test(20, 30);
            }
        }


        // Constructor is a special method present inside a class responsible for initializing the variable of that class
        // When you compile your program the above program will look like as below:

    }
}
