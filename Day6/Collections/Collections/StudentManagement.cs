using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class StudentManagement
    {
        

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Student(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
            }
        }

        class Program
        {
            static void Maingggg()
            {
                ArrayList students = new ArrayList();
                int choice;
                do
                {
                    Console.WriteLine("\nStudent Management System");
                    Console.WriteLine("1. Add Student");
                    Console.WriteLine("2. Display Students");
                    Console.WriteLine("3. Remove Student");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Student ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Student Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Student Age: ");
                            int age = Convert.ToInt32(Console.ReadLine());
                            students.Add(new Student(id, name, age)); // Using ArrayList's Add() method
                            Console.WriteLine("Student added successfully.");
                            break;

                        case 2:
                            Console.WriteLine("\nList of Students:");
                            if (students.Count == 0)
                            {
                                Console.WriteLine("No students found.");
                            }
                            else
                            {
                                foreach (Student student in students)
                                {
                                    Console.WriteLine($" ID: {student.Id}\n Name: {student.Name}\n Age: {student.Age}");
                                }
                            }
                            break;

                        case 3:
                            Console.Write("Enter Student ID to remove: ");
                            int removeId = Convert.ToInt32(Console.ReadLine());
                            Student studentToRemove = null;
                            foreach (Student student in students)
                            {
                                if (student.Id == removeId)
                                {
                                    studentToRemove = student;
                                    break;
                                }
                            }
                            if (studentToRemove != null)
                            {
                                students.Remove(studentToRemove); // Using ArrayList's Remove() method
                                Console.WriteLine("Student removed successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Student ID not found.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                } while (choice != 4);
            }
        }

}
}


