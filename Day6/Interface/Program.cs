using System;

// ---------------------- INTERFACES ----------------------
interface IHR
{
    void LastDrawn();
}

interface ISalaryDetails
{
    void LastDrawn();
}

// ---------------------- ABSTRACT CLASS ----------------------
abstract class APersonalDetails
{
    protected string PanNumber;

    public abstract void GetAPanDetails(); // Abstract method

    public void SetAPanDetails(string panNumber) // Non-abstract method
    {
        PanNumber = panNumber;
        Console.WriteLine($"PAN Details Set: {PanNumber}");
    }

    private void SetBasicPay() // Private method
    {
        Console.WriteLine("Basic pay structure set.");
    }

    public void ShowBasicPay()
    {
        SetBasicPay();
    }
}

// ---------------------- PERMANENT EMPLOYEE ----------------------
class PermanentEmployee : APersonalDetails, ISalaryDetails
{
    private double salary;

    public PermanentEmployee(double salary)
    {
        this.salary = salary;
    }

    public override void GetAPanDetails()
    {
        Console.WriteLine("Fetching Permanent Employee PAN Details...");
    }

    public void LastDrawn()
    {
        Console.WriteLine($"Permanent Employee's Last Drawn Salary: {salary}");
    }
}

// ---------------------- CONTRACTUAL EMPLOYEE ----------------------
class ContractualEmployee : APersonalDetails, ISalaryDetails
{
    private double contractPay;

    public ContractualEmployee(double contractPay)
    {
        this.contractPay = contractPay;
    }

    public override void GetAPanDetails()
    {
        Console.WriteLine("Fetching Contractual Employee PAN Details...");
    }

    public void LastDrawn()
    {
        Console.WriteLine($"Contractual Employee's Last Drawn Salary: {contractPay}");
    }
}

// ---------------------- MAIN PROGRAM ----------------------
class Program
{
    static void Main()
    {
         
        Console.WriteLine("---- Last Drawn Salary of Permanent Employee Details ----");
        PermanentEmployee pe = new PermanentEmployee(576568);
        pe.SetAPanDetails("WERTHJK6543");
        pe.GetAPanDetails();
        pe.LastDrawn();
       // pe.ShowBasicPay();


        
        string pancon = Console.ReadLine();
        Console.WriteLine("\n---- Last Drawn Salary of Contractual Employee Details ----");
        ContractualEmployee ce = new ContractualEmployee(66566);
        ce.SetAPanDetails("XCVVBNM5346");
        ce.GetAPanDetails();
        ce.LastDrawn();
       // ce.ShowBasicPay();
    }
}

/*
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("**************Enter details of permanent employee************");
        Console.WriteLine("Enter the salary of Permanent Employee");
        double salper = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the PAN No: ");
        string pan = Console.ReadLine();
        Console.WriteLine("---- Permanent Employee Details ----");
        PermanentEmployee pe = new PermanentEmployee(salper);
        pe.SetAPanDetails(pan);
        pe.GetAPanDetails();
        pe.LastDrawn();
        pe.ShowBasicPay();

        Console.WriteLine("\n**************Enter details of contractual employee************");
        Console.WriteLine("Enter the salary of Contractual Employee: ");
        double salcon = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the PAN No: ");
        string pancon = Console.ReadLine();
        Console.WriteLine("\n---- Contractual Employee Details ----");
        ContractualEmployee ce = new ContractualEmployee(salcon);
        ce.SetAPanDetails(pancon);
        ce.GetAPanDetails();
        ce.LastDrawn();
        ce.ShowBasicPay();
    }
}
*/