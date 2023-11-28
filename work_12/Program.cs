using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter The Start Number: ");
            //int startNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the End Number : ");
            //int endNumber = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"The Prime Numbers between {startNumber} and {endNumber} are : ");
            //for (int i = startNumber; i <= endNumber; i++)
            //{
            //    int counter = 0;
            //    for (int j = 2; j <= i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            counter++;
            //            break;
            //        }
            //    }

            //    if (counter == 0 && i != 1)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}

            //Console.Write("Enter the first Number :");
            //int firstNumber=int.Parse(Console.ReadLine());
            //Console.Write("Enter the End Number :");
            //int endNumber=int.Parse(Console.ReadLine());
            //Console.WriteLine($"The prime number is between {firstNumber} and {endNumber} are :");
            //for(int i = firstNumber; i <= endNumber; i++)
            //{
            //    int counter = 0;
            //    for(int r =2; r <= i /2; r++)
            //    {
            //       if(i % r == 0)
            //        {
            //            counter++;
            //            break;
            //        }
            //    }
            //   if(counter == 0 && i != 1)
            //    {
            //        Console.Write("{0} ", i);
            //    }
            //}
            Console.Write("Enter the first Number :");
            int firstNumber=int.Parse(Console.ReadLine());
            Console.Write("Enter the second Number :");
            int secondNum=int.Parse(Console.ReadLine());
            Console.WriteLine($"the prime number is between {firstNumber} and {secondNum} are :");
            for (int i =firstNumber; i<=secondNum; i++)
            {
                int counter = 0;
                for(int r=0; r<=i /2; r++)
                {
                    if (r % 2 == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if(counter == 0 && i != 1)
                {
                    Console.WriteLine("{0}", i);

                }
            }
            Console.ReadKey();
        }
    }
}