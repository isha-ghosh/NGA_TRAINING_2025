using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    class Programm
    {

        static void Main()
        {
            // OPEN / Closed Principal
            //to get the payment using credit card I need to achieve it with abstraction
            IPayment pm = new CreditCaard(); // we can switch the payment methods here
            PaymentProcessing processing = new PaymentProcessing(pm); //High level class
            processing.ExecutePayment(1000);


            // loosely coupled :  paymentprocessor class directly  depends on Ipayment method rather than a specific class
            // If we need to add another payment method we need to  modify paymentprocessing ( Easy extension of classes
            //Supports DI  : We can inject any payment method dynamically at runtime and also can test the modules

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    internal class PaymentProcessing
    {

        private readonly IPayment _payment;


        //Injecting dependency via constructor 
        // High level module is dependent on low level modules but via abstraction
        public PaymentProcessing(IPayment pm)
        {
            _payment = pm;

        }
        public void ExecutePayment(decimal amount)
        {
            _payment.ProcessPayment(amount);

        }
    }

}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    interface IPayment
    {
        void ProcessPayment(decimal amount);
    }


    public class CreditCaard : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class Paytm : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }


}














using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    interface IPayment
    {
        void ProcessPayment(decimal amount);
    }


    public class CreditCaard : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }

    public class Paytm : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            throw new NotImplementedException();
        }
    }


}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    internal class PaymentProcessing
    {


        // universal adapter // Interface
        private readonly IPayment _payment;


        //Injecting dependency via constructor or we can also inject through get / set
        // High level module is dependent on low level modules but via abstraction
        public PaymentProcessing(IPayment pm)
        {
            _payment = pm;

        }
        public void ExecutePayment(decimal amount)
        {
            _payment.ProcessPayment(amount);

        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipless
{
    class Programm
    {

        static void Main()
        {
            // OPEN / Closed Principal
            //to get the payment using credit card I need to achieve it with abstraction
            IPayment pm = new CreditCaard(); // we can switch the payment methods here
            PaymentProcessing processing = new PaymentProcessing(pm); //High level class
            processing.ExecutePayment(1000);


            // loosely coupled :  paymentprocessor class directly  depends on Ipayment method rather than a specific class
            // If we need to add another payment method we need to  modify paymentprocessing ( Easy extension of classes
            //Supports DI  : We can inject any payment method dynamically at runtime and also can test the modules
            // both high level should not depend on low level . Both should depend on abstraction(Interface)
        }
    }
}
