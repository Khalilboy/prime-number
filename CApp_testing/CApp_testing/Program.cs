using System;

namespace CApp_testing
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter any number:)");
            int number = int.Parse(Console.ReadLine());
            bool prime = true;

            for (int i = 2; i < number/2; i++)
            {
                if(number % i ==0)
                {
                    prime = false;
                    break;
                }
            }
            if(prime)
            {
                Console.WriteLine("number is prime.");
            }
            else
            {
                Console.WriteLine("number is not prime.");
            }
            Console.ReadKey();
        }
    }
}
