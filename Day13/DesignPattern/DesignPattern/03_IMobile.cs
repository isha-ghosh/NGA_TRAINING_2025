using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern;

namespace DesignPattern
{
    public interface IMobile
    {
        void GetModelDetails();
    }
}
//concrete class
public class IPhone : IMobile
{ 
    public void GetModelDetails()
    {
        Console.WriteLine("Iphone specification");

    }
}
//concrete class
public class Android :IMobile
{
    public void GetModelDetails()
    {
        Console.WriteLine("Android specification");

    }
}
