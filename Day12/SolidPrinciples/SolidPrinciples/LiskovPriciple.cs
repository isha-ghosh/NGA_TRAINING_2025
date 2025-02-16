using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesgfhjg
{
    

        public interface IWithdrawable
        {
            void Withdraw(double amount);
        }

        public class BankAccount
        {
            protected double balance;

            public virtual void Deposit(double amount)
            {
             
                balance += amount;
                
            }

            public double GetBalance()
            {
                return balance;
            }
        }

        public class SavingsAccount : BankAccount, IWithdrawable
        {
            public virtual void Withdraw(double amount)
            {
                if (amount <= 0)
                    throw new ArgumentException("Withdrawal amount must be positive.");

                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient balance.");
                }
            }
        }

    
        public class FixedDeposit : BankAccount
        {
            

            public FixedDeposit(double initialDeposit)
            {
                if (initialDeposit <= 0)
                    throw new ArgumentException("Initial deposit must be positive.");
                
                balance = initialDeposit;
              
            }

            
        }
    


}
