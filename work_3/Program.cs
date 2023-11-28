using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_3
{
    internal class Program
    {
        public static void Main()
        {
            //int num;
            //Console.Write("Check whether a number is positive or negative:\n");
            //Console.Write("----------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input an integer :");
            //num = int.Parse(Console.ReadLine());
            //if (num >= 0)
            //{
            //    Console.WriteLine("{0} is a positive number....\n", num);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is a negative number....\n", num);
            //}

            Console.WriteLine("Check whether a num is negative or positive!!");
            Console.Write("Enter a number :");
            int num =int.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("{0} is a positive number !!",num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number !!",num); ;
            }

            Console.ReadKey();
        }

    }
}
