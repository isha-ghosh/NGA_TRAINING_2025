using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    internal class PatterbMatching
    {

        class Program
        {
            public static void Main6566(string[] args)
            {
                /* OldService service1 = new OldService();
                 service1.Test1();
                 service1.Test2();
                 service1.Test3();
                 service1.Test4(50);*/


                /*   string word = "C# is a powerful language";

                  int wordcount =  word.GetWordCounted();
                   Console.WriteLine("Total words in a given string :" + wordcount);*/


                /* string s = "03";
                 DateTime date;

                 if (DateTime.TryParse(s, out date))
                 {
                     Console.WriteLine(date);

                 }

                 Console.WriteLine("It's done");*/



                Circle circleobj = new Circle(10);
                Displayarea(circleobj);

                Rectangle recobj = new Rectangle(20, 30);

                //  Rectangle rec = null;
                Displayarea(recobj);

            }


            public static void Displayarea(Shape shape)


            {
                // Using is key word 

                /* // if variable shape  holds the object of type Circle ,
                // then it will store that object in variable c
                if (shape is Circle c) {

                  //  Circle c = (Circle)shape;

                    Console.WriteLine("Area of circle is : " + c.Radius * c.Radius *Shape.PI);

                }


                if (shape is Rectangle r)
                {

                //    Rectangle r = (Rectangle)shape;

                    Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);

                }
        */

                // using switch 

                switch (shape)

                {
                    case Circle c:
                        Console.WriteLine("Area of circle is : " + c.Radius * c.Radius * Shape.PI);
                        break;
                    case Rectangle r:
                        Console.WriteLine("Area of Rectangle is : " + r.Length * r.Height);
                        break;
                    default:
                        throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
                    case null:
                        throw new ArgumentNullException(nameof(shape));





                }



            }
        }


    }
}
