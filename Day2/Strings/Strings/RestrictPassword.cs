using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Password
    {
        private readonly string P;
        public Password(string pass)
        {
            P = pass;
        }
        public string getPassword()
        {
            return P;
        }
        public void setPassword(string newpass)
        {
            Console.WriteLine("Password cannot be modified..");

        }
        internal class RestrictPassword
        {
            public static void rrrpp(string[] args)
            {

                Password a = new Password("Password123");
                a.setPassword("345");
                Console.WriteLine(a.getPassword());
            }

        }
    }
}





