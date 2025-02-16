using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class GenericMethods
    {
        public void GenericMethod<T1,T2>(T1 t1, T2 t2)
        {
            Console.WriteLine($"value1 : {t1} value2 : {t2}");
        }
    }

}
