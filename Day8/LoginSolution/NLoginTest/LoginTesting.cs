using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginSolution;


namespace NLoginTest
{

    [TestFixture]
    public class LoginTesting
    {
        Login l= new Login();
        
        [Test]
        public void Check_Username_Null()
        {
            string result =l.DoLogin(null, "admin");
            string expected = "Credentials must be provided";
            Assert.That(expected.Equals(result));
        }

        //Login result = Login.DoLogin(null, "admin");


        [Test]
        public void Check_Password_Null()
        {
            string result = l.DoLogin("admin", null);
            string expected = "Credentials must be provided";
            Assert.That(expected.Equals(result));
        }

        [Test]
        public void Check_Valid_Credentials()
        {
            string result =l.DoLogin("admin", "admin");
            string expected = "Login successful";
            Assert.That(expected.Equals(result));
        }
        

        [Test]
        public void Check_Both_Username_And_Password_Null()
        {
            string result = l.DoLogin(null, null);
            string expected = "Credentials must be provided";
            Assert.That(expected.Equals(result));

        }

    }
}


/*
 /For the above three create three test cases  
//Check_username_null
//Check_password_null 
//check
namespace LoginTestCase
{
    [TestClass]
    public sealed class Test1
    {
        Login login = new Login();
        string loginresult;
        [TestMethod]
        public void Check_username_null()
        {
               
            Login.DoLogin(null, "admin",out loginresult);
            Console.WriteLine(loginresult);

        }
        [TestMethod]
        public void Check_password_null()
        {
            Login.DoLogin("admin", null , out loginresult);
            Console.WriteLine(loginresult);
        }
        [TestMethod]
        public void Check()
        {
            Login.DoLogin("admin", "admin", out loginresult);
            Console.WriteLine(loginresult);
        }
        
        [TestMethod]
        public void Check_both_null()
        {
            Login.DoLogin(null, null , out loginresult);
            Console.WriteLine(loginresult);
        }
        //Incorrect username and password   
        [TestMethod]
        public void Check_both()
        {
            Login.DoLogin("asddas", "sad", out loginresult);
            Console.WriteLine(loginresult);
        }
}
}

        
        
        
        
    }
}
 */