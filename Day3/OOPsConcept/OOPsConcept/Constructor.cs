using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    internal class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(Person p)
        {
            Name = p.Name;
            Age = p.Age;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {Name} and Age: {Age}");
        }
        class MainProgram
        {
            static void Main(string[] args)
            {
                Person p1 = new Person("Isha", 22);
                p1.Display();
                Person p2 = new Person(p1);
                p2.Display();
                p2.Name = "Disha";
                p2.Age = 18;
                p2.Display();
            }
        }
    }
}
