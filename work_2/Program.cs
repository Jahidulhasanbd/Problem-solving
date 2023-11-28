using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_2
{
    internal class Program
    {
        public static void Main()
        {
            //int num1, rem1;
            //Console.Write("\n\n");
            //Console.Write("Check whether a number is even or odd!!!");
            //Console.Write("__________________________________");
            //Console.Write("\n\n");
            //Console.Write("Enter a number:");
            //num1=int.Parse(Console.ReadLine());
            //rem1 = num1 % 2;
            //if(rem1 == 0)
            //{
            //    Console.WriteLine("{0} is an even integer",num1);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is an odd integer",num1);
            //}
            Console.WriteLine("Check whether is number is even or odd !!");
            Console.Write("Enter a number :");
            int num=int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("{0} number is Even!!",num);
            }
            else
            {
                Console.WriteLine("{0} number is odd!!",num);
            }
            Console.ReadKey();
        }

    }
}
