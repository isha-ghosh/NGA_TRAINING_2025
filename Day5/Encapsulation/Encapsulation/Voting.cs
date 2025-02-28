using System;

class Voting
{
    private int age;

    public Voting(int age)
    {
        this.age = age;
    }

    
        public void CheckEligibility()
    {
        if (age >= 18)
        {
            Console.WriteLine($"Age {age}: Eligible to vote.");
        }
        else
        {
            int yearsLeft = 18 - age;
            Console.WriteLine($"Age {age}: Not eligible to vote. Wait for {yearsLeft} years.");
        }
    }
}


class Program
{
    static void Mainnnnnn()
    {
       
        Console.WriteLine("Enter the number of voters: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Voting[] voters = new Voting[x];

        for (int i = 0; i < x; i++)
        {
            Console.WriteLine($"Enter details of voter {i + 1}: ");
            Console.Write("Enter age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            voters[i] = new Voting(age); 
        }

        Console.WriteLine("\nVoting Eligibility Results:");
        foreach (var voter in voters)
        {
            voter.CheckEligibility(); 
        }
    }

    
}

