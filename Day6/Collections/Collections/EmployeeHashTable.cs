

using System.Collections;
using System;

namespace Collections
{
    internal class EmployeeHashTable
    {
   

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string designation, double salary)
    {
        Id = id;
        Name = name;
        Designation = designation;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Designation: {Designation}, Salary: {Salary}");
    }
}

class Program
{
    static void Mai0n()
    {
        Hashtable employees = new Hashtable();
        int choice;

        do
        {
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Employees");
            Console.WriteLine("3. Remove Employee by ID");
            Console.WriteLine("4. Update Employee Salary");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Employee ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    if (employees.ContainsKey(id))
                    {
                        Console.WriteLine("Employee with this ID already exists!");
                        break;
                    }
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Designation: ");
                    string designation = Console.ReadLine();
                    Console.Write("Enter Salary: ");
                    double salary = Convert.ToDouble(Console.ReadLine());

                    employees.Add(id, new Employee(id, name, designation, salary));
                    Console.WriteLine("Employee added successfully.");
                    break;

                case 2:
                    Console.WriteLine("\nList of Employees:");
                    if (employees.Count == 0)
                    {
                        Console.WriteLine("No employees found.");
                    }
                    else
                    {
                        foreach (DictionaryEntry entry in employees)
                        {
                            ((Employee)entry.Value).Display();
                        }
                    }
                    break;

                case 3:
                    Console.Write("Enter Employee ID to remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    if (employees.ContainsKey(removeId))
                    {
                        employees.Remove(removeId);
                        Console.WriteLine("Employee removed successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Employee ID not found.");
                    }
                    break;

                case 4:
                    Console.Write("Enter Employee ID to update salary: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());
                    if (employees.ContainsKey(updateId))
                    {
                        Console.Write("Enter new Salary: ");
                        double newSalary = Convert.ToDouble(Console.ReadLine());
                        ((Employee)employees[updateId]).Salary = newSalary;
                        Console.WriteLine("Salary updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Employee ID not found.");
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 5);
    }
}
    }
}
