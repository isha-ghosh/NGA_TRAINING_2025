using System;
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
            //Console.WriteLine("Hello");
            int length = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());
            int area = length * breadth;
            Console.WriteLine("Area of rectangle is "+ area);
            
            //Console.Write("Enter length: ");

            //int length = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter width: ");
            //int width = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Area is: " + length * width);


        }
    }
}




