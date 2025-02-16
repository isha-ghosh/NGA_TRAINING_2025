/*
 Create  a program that  will creates a  log folder (Logs/) if it doesn't exist and then add user details 
(name , age , email and timestamp)to a log file . Read and then prints all user details line by line.
 */


using System;
using System.Collections.Generic;
using System.IO;


namespace Collections
{
    internal class StudentLog
    {/*
        class UserLogger
        {
            static string logDir = "Logs";
            static string logFile = Path.Combine(logDir, "user_logs.txt");

            static void Main()
            {
                
                // Ensure the log directory exists
                if (!Directory.Exists(logDir))
                {
                    Directory.CreateDirectory(logDir);
                }

                // Get user details
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                string age = Console.ReadLine();

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                // Write user details to log file
                LogUserDetails(name, age, email);

                // Read and print all user logs
                Console.WriteLine("User Logs:");
                ReadUserLogs();
            }

            static void LogUserDetails(string name, string age, string email)
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string logEntry = $"{name}, {age}, {email}, {timestamp}";

                File.AppendAllText(logFile, logEntry + Environment.NewLine);
            }

            static void ReadUserLogs()
            {
                if (File.Exists(logFile))
                {
                    string[] lines = File.ReadAllLines(logFile);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("No logs found.");
                }
            }
        }*/

        
class UserLogger
    {
        // Define log directory and file path
        static string logDir = "Logs";
        static string logFile = Path.Combine(logDir, "user_logs.txt");

        static void Mai7887n()
        {
            // Ensure the log directory exists
            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }

            // Get user details
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            // Save user details to file
            SaveUserDetails(name, age, email);

            // Read and print all user logs
            Console.WriteLine("\n--- User Logs ---");
            ReadUserLogs();
        }

        static void SaveUserDetails(string name, string age, string email)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string logEntry = $"{name}, {age}, {email}, {timestamp}";

            // Append details to log file
            File.AppendAllText(logFile, logEntry + Environment.NewLine);
            Console.WriteLine("User details saved successfully in user_logs.txt!");
        }

        static void ReadUserLogs()
        {
            if (File.Exists(logFile))
            {
                string[] lines = File.ReadAllLines(logFile);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No logs found.");
            }
        }
    }


}
}
