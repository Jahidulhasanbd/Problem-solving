using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_4
{
    internal class Program
    {
        public static void Main()
        {
            //int chck_year;
            //Console.Write("\n\n");
            //Console.Write("Check whether a given year is leap year or not...\n ");
            //Console.Write("\n\n");
            //Console.Write("Input a year:");
            //chck_year = int.Parse(Console.ReadLine());
            //if ((chck_year % 400) == 0)
            //{
            //    Console.WriteLine("{0} is leap year...", chck_year);
            //}
            //else if ((chck_year % 100) == 0)
            //{
            //    Console.WriteLine("{0} is not a leap year....", chck_year);
            //}
            //else if ((chck_year % 4) == 0)
            //{
            //    Console.WriteLine("{0} is a leap year....", chck_year);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not a leap year..", chck_year);
            //}

            //Console.WriteLine("Check whether a given year is leap year or not!!!");
            //Console.Write("Enter a year :");
            //int year = int.Parse(Console.ReadLine());
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine("This year is a leap year ...");
            //}
            //else if (year % 100 == 0)
            //{
            //    Console.WriteLine("This year is not a leap year.");
            //}
            //else if (year % 400 == 0)
            //{
            //    Console.WriteLine("This year is  a leap year");
            //}
            //else
            //{
            //    Console.WriteLine("This year is not a leap year ");
            //}



            //Console.WriteLine("Check whether a given year is leap year or not!!!");
            //Console.Write("Enter a year :");
            //int year = int.Parse(Console.ReadLine());
            //if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            //{
            //    Console.WriteLine("This year is a leap year ...");
            //}

            //else
            //{
            //    Console.WriteLine("This year is not a leap year ");
            //}

            Console.WriteLine("check whether a year is leap year or not !!!!");
            Console.Write("Enter a year :");
            int chkyear=int.Parse(Console.ReadLine());
            if((chkyear %4==0 && chkyear %100 !=0)|| (chkyear % 400 == 0))
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("This year is not a leap year");
            }


            Console.ReadKey();
        }
    }
}



