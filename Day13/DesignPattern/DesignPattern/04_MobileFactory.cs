using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
   public interface MobileFactory
    {
        public static IMobile getMobile(string type)
        {
            if (type.ToLower() == "android")
                return new Android();
            else if (type.ToLower() == "iphone")
                return new IPhone();
            else
                throw new ArgumentException("Invalid type");
        }
    }
}
