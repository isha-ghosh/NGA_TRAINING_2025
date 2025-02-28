using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Create a dll of login class where you have
//One method DoLogin(string username , string password)
 
//{
// // Logic  - 1)string values It should be not be empty  // Credentials must be provided
//Username is it equal admin and the password is admin
//Otherwise it will return invalid credentials

//}
 
//For the above three create three test cases 
//Check_username_null
//Check_password_null
//check






namespace LoginSolution
{
    public class Login
    {
        
            public string DoLogin(string username, string password)
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    return "Credentials must be provided";
                }

                return (username == "admin" && password == "admin") ? "Login successful" : "Invalid credentials";
            }
        
    }

}

/*
 //Create a login class where you have 
//One method DoLogin(string username , string password)
//Logic - 1)string values It should be not be empty 
//	2) Username is it equal admin and the password is admin
//Otherwise it will return invalid credentials

public class Login
{
    public string Username { get; set; }
    public string Password { get; set; }

    public static string check { get; set; }

    public static void DoLogin(string username, string password, out string result)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            result = "Invalid credentials";
        }
        if (username == "admin" && password == "admin")
        {
            result =  "Valid credentials";
        }
        else
        {
            result = "Invalid credentials";
        }
        
    }
    public Login(string username, string password)
    {
        Username = username;
        Password = password;
    }
    public Login()
    {
    }
    public static void Main(string[] args)
    {
        Login login = new Login("admin", "admin");
        //DoLogin("admin", "admin");
    }
}
 */