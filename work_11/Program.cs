using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //how to check if a given number is prime or not
            Console.Write("Enter a number :");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("The number is prime.");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }

            Console.ReadKey();
        }
    }
}
