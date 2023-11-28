using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_prctc
{
    internal class Program
    {
        public static void Main()
        {
            //int int1, int2;
            //Console.Write("\n\n");
            //Console.Write("Check whether two integers are equal or not:\n");
            //Console.Write("-------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Input 1st number:");
            //int1=int.Parse(Console.ReadLine());
            //Console.Write("Input 2nd number:");
            //int2 = int.Parse(Console.ReadLine());
            //if(int1 == int2)
            //{
            //    Console.WriteLine("{0} and {1} are equal....\n",int1,int2);
            //}
            //else
            //{
            //    Console.WriteLine("{0} and {1} are not equal....\n",int1,int2);
            //}
            Console.WriteLine("Check whether two number is equal or not !!!");
            Console.Write("Enter First number :");
            int firstNum=int.Parse(Console.ReadLine());
            Console.Write("Enter Second number :");
            int SecondNum = int.Parse(Console.ReadLine());

            if (firstNum == SecondNum)
            {
                Console.WriteLine($"{firstNum} and {SecondNum} is equal!!",firstNum,SecondNum);
            }
            else
            {
                Console.WriteLine($"{firstNum} and {SecondNum} is not equal!!",firstNum,SecondNum);
            }
            Console.ReadKey();
                
        }

    }
}
