using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7
{
    internal class LocalFunctions
    {
        /*
                
            public static void run()
            {
                Console.WriteLine(calculateaddition(20, 12));
                Console.WriteLine(calculatesubtraction(20, 12));
            }
            /*static int calculateaddition(int a, int b)
            {
                return a+b;
            }
            static int calculatesubtraction(int a, int b)
            {
                return a - b;
            }*/
         /*   static int calculateaddition(int a, int b)
            {
                int Add() => a + b;
                return Add();
            }
            static int calculatesubtraction(int a, int b)
            {
                int subNumbers(int x, int y)
                {
                    if (x > y && x > 0 && y > 0)
                    {
                        return x - y;
                    }
                    else if (y > x)
                    {
                        return y - x;
                    }
                    return 0;
                }

                // Call the local function inside the method
                return subNumbers(a, b);
            }
            //compile time null safety
            static string GetyouLuck(int day) => day switch
            {
                1 => "Good Luck",
                2 => "Bad Luck",
                3 => "can't exit"
            };
        */
        
        enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        class MoreExamples
        {
            //2.  local functions
            /*  static  int calculateaddition(int a, int b)
              {
                  int Add() => a + b;
                  return Add();

              }*/
            static string Getyourday(WeekDays day) => day switch
            {

                WeekDays.Monday => "Good Luck",
                WeekDays.Tuesday => "Good Luck",
                WeekDays.Wednesday => "",
                WeekDays.Thursday => "",
                WeekDays.Friday => "",
                WeekDays.Saturday => ""



            };


            public static void Main00(String[] args)
            {
                /* static int calculateaddition(int a, int b)
                 {
                     return a + b;


                 }

                 static int Calculatesubstraction(int a , int b)
                 {

                     return a - b;

                 }

                 Console.WriteLine(calculateaddition(45, 67));*/

                // Console.WriteLine(calculateaddition(45, 67));


                //2. compile time null safety(give you a warning before running)



                /* static string GetyourLuck(int day) => day switch
                 {

                     1 => "Good Luck",
                     2 => " Bad Luck",




                 };*/

                /* static string GetBooleanValue(bool flag) => flag switch
                 {

                     true => " YES"

                 };*/

                Console.WriteLine("Enter the value :");

                String s = Console.ReadLine();

                WeekDays week = WeekDays.Sunday;
                Console.WriteLine(Getyourday(week));
            }
        }





    }


}

A