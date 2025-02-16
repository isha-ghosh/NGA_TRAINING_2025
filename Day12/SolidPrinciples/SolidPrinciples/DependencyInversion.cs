using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public interface IPaymentMethod
    {
        void ProcessPayment();
    }

    public class CreditCard : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Credit Card payment processed.");
        }
    }

    public class Paytm : IPaymentMethod
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Paytm payment processed.");
        }
    }

    public class PaymentProcessing
    {
        private IPaymentMethod _paymentMethod;

        public PaymentProcessing(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ExecutePayment()
        {
            _paymentMethod.ProcessPayment();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continuePayment = true;

            while (continuePayment)
            {
                Console.WriteLine("\nSelect Payment Method:");
                Console.WriteLine("1. Credit Card");
                Console.WriteLine("2. Paytm");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ProcessPayment(new CreditCard());
                        break;

                    case "2":
                        ProcessPayment(new Paytm());
                        break;

                    case "3":
                        continuePayment = false;
                        Console.WriteLine("Exiting the application.");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void ProcessPayment(IPaymentMethod paymentMethod)
        {
            PaymentProcessing processor = new PaymentProcessing(paymentMethod);
            processor.ExecutePayment();
        }
    }
}
