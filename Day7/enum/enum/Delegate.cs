using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//   public class Delegates
//{
//    public delegate void printde();//reating a delegate
//        static void Main(string[] args)
//    {
//        printde pd=new printde(printData);
//        pd();
//    }
//    public static void printData()
//    {
//        Console.WriteLine("Delegates");
//    }
//}



namespace NewFunctionalities
{
    public class DelegateExample
    {
        //  public delegate void PrintDelegate(int data); // Creating a delegate
        public delegate void Operations(int a, int b);
        public delegate void showdelegate(int data);
        static void Main(string[] args)
        {
            //   DelegateExample example = new DelegateExample();
            //  PrintDelegate pd = new PrintDelegate(printData); // create an object of a delegate class , which will point to a me
            // pd();

            showdelegate data = new showdelegate(showdata);
            //  Operations op = new Operations(Subtract);
            //  op += new Operations(Add);
            //   pd(4, 4);

            Subtract(4, 4, data);




        }

        public static void printData()
        {
            Console.WriteLine("Delegate associated Method has been called :");

        }


        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("The addition of two numbers :");

        }

        public static void Subtract(int a, int b, showdelegate pd)
        {
            int result = a - b;
            //   Console.WriteLine("The subtraction of two numbers :");

        }

        public static void showdata(int result)
        {
            Console.WriteLine("Operations performed:" + result);

        }
    }
}
