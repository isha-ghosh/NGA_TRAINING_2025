﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


using System;
using ClassLibrary1;

namespace ProgramAccessSpecifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 obj = new Class1();

            obj.display();
        }
    }

    public class ConsoleClass1 : Class1   // Derived class
    {


        public void display()
        {

            Console.WriteLine(Id); // You cannot access the private member in any of the derived  class
        }

    }

    public class ConsoleClass2  // Non- Derived class 
    {

        public void display()
        {


            //   Console.WriteLine(Id); // You cannot access the private member in any of the non-derived class

        }
    }
}

