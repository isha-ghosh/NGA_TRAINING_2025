using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Systems
{
    
        public class Class1
        {
            public Class1()
            {
                /*ArrayList() -- used to initialize a new instance of the AL that is empty and has the default initial capacity 

                  ArrayList(Collection c ) -- when we want to copy the content of one list to another

                 ArrayList(int capacity) -- capacity means the no. of elements that the new list can initially store but it may grow dynamicallu.


                 */


                ArrayList ar = new ArrayList();
                ar.Add(1); //  all the elements are added in an object  
                           //	ar.Add("String value");
                ar.Add((int)1); // saving a primitive type of value after casting
                                //	ar.Add(" ");
                                //    ar.Add(null);

                int fe = (int)ar[0];
                //  string se = (string)ar[4];

                ar.Insert(1, 565);

                //  Console.WriteLine($"{fe} , { se}");

                foreach (var item in ar)
                {
                    Console.WriteLine(item);

                }





            }


        }
    
}