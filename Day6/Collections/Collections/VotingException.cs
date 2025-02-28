using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class VotingException
    {
        
class VotingEligibility
    {
        static void Main777()
        {
            try
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                // Try to parse the input to an integer
                if (!int.TryParse(input, out int age))
                {
                    throw new FormatException("Invalid input! Age must be a number.");
                }

                // Check if age is less than 18
                if (age < 18)
                {
                    throw new ArgumentException("You are not eligible to vote! Age must be 18 or above.");
                }

                Console.WriteLine("You are eligible to vote!");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Thank you for using the voting eligibility checker.");
            }
        }
    }

}
}
