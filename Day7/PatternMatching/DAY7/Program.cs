using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAY7;

namespace DAY7
{







    //If we want to add new functionality into the service class if we are not aware of the source code






    class Program
    {
        static void Main(string[] args)
        {
            /* OldService Sobj = new OldService();

              Sobj.Test1();
              Sobj.Test2();
              Sobj.Test3();
              Sobj.Test4(1);*/
            /* string word = "C# is a powerful language";

             int wordcount = word.GetWordCounted();
             Console.WriteLine("Total words in a given string :" + wordcount);*/
            Employee e = new Employee(101, "Niti", "Trainer");

            Console.WriteLine(e[2]);
            //To set the value 
            e[2] = "Preeti";

            Console.WriteLine("After resetting the value ; ");
            Console.WriteLine(e[2]);

            e["Name"] = "Kriti";
            e["job"] = "Corporate Trainer";

            Console.WriteLine("After resetting the value ; ");
            Console.WriteLine(e["Name"]);
            Console.WriteLine(e["job"]);


        }
    }
}
