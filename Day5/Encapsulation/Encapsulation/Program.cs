using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulation;

namespace Encapsulation
{
    /*public class Bank
    {
        private double balance;
        public double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double balance)
        {
            if (balance > 0)
            {
                this.balance = balance;
            }
            else
            {
                Console.WriteLine("Value entered negative");
            } //throw new Exception("Value entered negative");

        }
        
    }*/
    public class Voting
    {
        private int Age;
        public int GetAge()
        {
            return Age;
        }
        public void SetAge(int age)
        {
            
         
            if (age >= 18)  
            {
                Age = age;
                Console.WriteLine("Eligible for voting. Age= " + age);
            }
            else
            {
                int yearsLeft = 18 - age;
                Console.WriteLine("Not eligible for voting. Age= " + age + ". Wait for " + yearsLeft + " years.");
            }

        }
    }
    class Program
    {
        static void Mainnnn(string[] args)
        {
            /*Bank bank = new Bank();
           //Console.WriteLine(bank.balance);
            bank.SetBalance(-460);
            Console.WriteLine(bank.GetBalance());*/
            Voting v = new Voting();
            Console.WriteLine("Enter your age");
            int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(v.age);
            v.SetAge(x);
            //Console.WriteLine(v.GetAge());
        }
    }
}



