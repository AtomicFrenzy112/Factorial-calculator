using System;

namespace Factorial_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The Factorial of a positive integer, n, is defined as the product of the sequence n, n-1, n-2,
             * ...1 and the factorial of zero, 0, is defined as being 1.*/


            Console.WriteLine("Enter positive integer");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = num;
            

            if (num < 0)
            {
                Console.WriteLine("Not a positive integer");
                
            }

            for (int i = 1; i <num;i++)
            {           
                factorial = factorial * (num - i);
                               
            }

            if (num == 0)
            {
                factorial = 1;
            }
            Console.WriteLine(factorial);
        }
    }
}
