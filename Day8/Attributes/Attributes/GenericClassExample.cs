using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class GenericClass<T>
    {
        private T GenericVariable;
        public GenericClass(T localvariable)
        {
            GenericVariable = localvariable;
        }
        public T GenericMethod(T GenericParameterValue)
        {
            Console.WriteLine($"Type od data: {typeof(T)}");
            return GenericVariable;
        }

        public T GenericProperty { get; set; }
    }
}
