using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
   
  
    public class Restaurant

    {
        /*
        //sequential execution   // Without multithreading

        static void ProcessOrder(string customerName, int timeToPrepare)
        {
            Console.WriteLine($"{customerName} placed an order.");
            Thread.Sleep(timeToPrepare * 1000); // Simulating preparation time
            Console.WriteLine($"{customerName}'s order is ready in {timeToPrepare} seconds.");
        }

       
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            ProcessOrder("Niti", 3);
              ProcessOrder("Jatin", 4);
              ProcessOrder("Aditi", 2);

              sw.Stop();
            Console.WriteLine($"Total time taken: {sw.Elapsed.Seconds} sec");
        }*/

        /*
        //parallel execution with async await
        static async Task ProcessOrder(string customerName, int timeToPrepare)
        {
            Console.WriteLine($"{customerName} placed an Order");
            await Task.Delay(timeToPrepare * 1000); //simulation for  preparation time
            Console.WriteLine($"{customerName} order is ready {timeToPrepare}");


        }
        // here main() is an async one which allows asynchronous execution 
        static async Task Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            
            // will run asynchronously in parallel  // multi 8 core cpu
            Task t1 = ProcessOrder("Niti", 3);
            Task t2 = ProcessOrder("Jatin", 4);
            Task t3 = ProcessOrder("Aditi", 2);

            await Task.WhenAll(t1, t2, t3); // wait for all the orders to complete
            sw.Stop();

            Console.WriteLine($"Total time taken: {sw.Elapsed.Seconds} sec");
        }
        */
        
        static void OrderProcessing()
        {
            ProcessOrder("Niti", 3);
        }

        static void InvoiceProcessing()
        {
            Console.WriteLine("Generating invoice...");
            Thread.Sleep(2000); // Simulate invoice processing time
            Console.WriteLine("Invoice generated successfully!");
        }

        static void SendSMS()
        {
            Console.WriteLine("Sending SMS notification...");
            Thread.Sleep(1000); // Simulate SMS delay
            Console.WriteLine("SMS sent successfully!");
        }

        static void ProcessOrder(string customerName, int timeToPrepare)
        {
            Console.WriteLine($"{customerName} placed an order.");
            Thread.Sleep(timeToPrepare * 1000); // Simulating preparation time
            Console.WriteLine($"{customerName}'s order is ready in {timeToPrepare} seconds.");
        }

        static void Main()
        {
            Console.WriteLine("Restaurant Started ...");

            Stopwatch sw = Stopwatch.StartNew();

            // Running tasks in parallel using threads
            Thread orderThread = new Thread(OrderProcessing);
            Thread invoiceThread = new Thread(InvoiceProcessing);
            Thread notificationThread = new Thread(SendSMS);

            orderThread.Start();
            invoiceThread.Start();
            notificationThread.Start();

            // Ensuring all threads complete execution
            orderThread.Join();
            invoiceThread.Join();
            notificationThread.Join();


            sw.Stop();
            Console.WriteLine($"All orders completed in {sw.Elapsed.TotalSeconds} seconds");
        }

    }
}
