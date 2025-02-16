using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProperties
{
    internal class Swithcase
    {
        public static void swithcase(string[] args)
        {
            int total = 0;
            bool keepOrdering = true;

            while (keepOrdering)
            {
                
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Pizza - Rs. 100");
                Console.WriteLine("2. Burger - Rs. 50");
                Console.WriteLine("3. Pasta - Rs. 200");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an item by entering its number: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                

                if (keepOrdering==true)
                {
                    switch (choice)
                    {
                        case 1:
                            total += 100;
                            Console.WriteLine("You selected Pizza. Price: Rs. 100");
                            break;
                        case 2:
                            Console.WriteLine("You selected Burger. Price: Rs. 50");
                            total += 50;
                            break;
                        case 3:
                            Console.WriteLine("You selected Pasta. Price: Rs. 200");
                            total += 200;
                            break;
                        case 4:
                            Console.WriteLine("Thank you for visiting!");

                            keepOrdering = false;
                            Console.WriteLine("Bill Amount: Rs. " + total);
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                //else
                //{
                //    Console.WriteLine("Invalid input. Please enter a number.");
                //}
                
            }

        }
    }
 }
