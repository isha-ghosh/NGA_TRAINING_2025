using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAY7;

namespace DAY7
{
       
// We need not to remember the class name where you have written a logic for a word count


       

    
        static class StringCount
        {

            public static int GetWordCounted(this string inputString)
            {

                if (!string.IsNullOrEmpty(inputString))
                {

                    string[] strArray = inputString.Split(' ');
                    return strArray.Count();
                }
                else
                {

                    return 0;
                }

            }

        }
    
}

