/* (GOF) --   Gang of Four  -- categorized the design pattern into three main categories based on the three problem areas :

Creational Design Pattern  :    Object Creation  and Initialization  : Singleton , Factory, Builder 

These patterns deal with object creation mechanism , trying to create objects in a manner suitable to the situation .  Creational design patterns solve this problem by controlling the object creation process
(IOC)

Structural Design Pattern :  Structural changes of relation between classes and Interfaces  . They help ensure that the entire structure doesn't need to change when one part of a system changes.

: Adapter  , Façade, Decorator, Composite, Proxy 

Behavioural Design Pattern :  The relationship between classes and communication between Objects : These patterns are focused on communication between objects  : How they interact and fulfil the requirement . They define clear patterns of communication among objects :

Chain of Responsibility design pattern, Observer design pattern, Strategy design pattern  





Singleton Design Pattern :

It ensures that only one instance of the Singleton class is created throughout the application 
We can do the lazy initialization  - > which means it is created when it is needed for the first time , not when the application starts.
Eager initialization : The object is ready when you execute your application , no matter you needed it or not there 
*/

namespace DesignPattern
{
    public sealed class Singleton
    {
        private static int cntr = 0;

        private static Singleton Instance = null;

        public static Singleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton(); //obj is already thre in the heap memory
            }
            return Instance;

        }

        private Singleton()
        {
            cntr++;
            Console.WriteLine("Counter Value :" + cntr.ToString());

        }

        public void Display(string message)
        {


            Console.WriteLine(message);


        }


    }



}