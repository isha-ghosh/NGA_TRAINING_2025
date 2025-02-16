using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleProgram;

namespace Strings
{
    internal class Program
    {
        public string Name;
        static void progg(string[] args)
        {
            Console.WriteLine("ggggg");
            //value type
            int a = 10;
            int b = 20;



            b = 20;

            Console.WriteLine($"a= {a} , b= {b}");


            //reference type
            Program e = new Program();
            e.Name = "CSharp";

            Program e1 = e;
            e1.Name = "Java";
            Console.WriteLine(e.Name);

        }
    }
}