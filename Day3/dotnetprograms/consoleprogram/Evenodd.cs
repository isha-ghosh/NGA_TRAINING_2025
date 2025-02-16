using System;
namespace Evenodd
{
    public static class Evenodd
    {
        public static void run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >= 2 && n <= 20)
            {
                if (n % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            else
                Console.WriteLine("Out of range");
        }
    }
}