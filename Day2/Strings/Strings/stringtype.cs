using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class stringtype
    {
        public static void Main(string[] args)
        {
            //int i = 1, j = 16;

            //while (++i <= j--)

            //{

            //    j++;

            //}

            //Console.WriteLine(i + "  " + j);



            //int j = 25;

            //string str = (j++ > 15) ? "Mumbai" : (j++ < 25) ? "Delhi" : "Chennai";

            //Console.WriteLine(str);



            //string
            string pass = "csharp";
            Console.WriteLine(pass);
            Console.WriteLine(pass.GetHashCode());
            pass = "java";
            Console.WriteLine(pass);
            Console.WriteLine(pass.GetHashCode());



            //stringbuilder
            StringBuilder s = new StringBuilder("Java is an interesting");
            s.Append("Language");
            Console.WriteLine(s.ToString());

        }
    }
}
