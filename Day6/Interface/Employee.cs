/*using System;

// HR Interface
interface IHR
{
    void LastDrawn();
}

// Salary Details Interface
interface ISalaryDetails
{
    void LastDrawn();
}

// Abstract Class for Employee Personal Details
abstract class APersonalDetails
{
    protected string PanNumber;

    public abstract void GetAPanDetails();

    public void SetAPanDetails(string panNumber)
    {
        PanNumber = panNumber;
        Console.WriteLine($"PAN Details Set: {PanNumber}");
    }

    private void SetBasicPay()
    {
        Console.WriteLine("Basic pay structure set.");
    }

    public void ShowBasicPay()
    {
        SetBasicPay();
    }
}

// Permanent Employee Class
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

// Contractual Employee Class
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

*/