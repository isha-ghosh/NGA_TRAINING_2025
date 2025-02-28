using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class MainProgram
    {
        public static void Mainhkh(string[] args)
        {
            Console.WriteLine("enter mob type");
            string mt = Console.ReadLine();
            try
            {
                IMobile m = MobileFactory.getMobile(mt);
                m.GetModelDetails();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
