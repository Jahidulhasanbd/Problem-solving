using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if any number of 1 to 100 is divided by 3 then print "Jahid",and if any number is divided by 5 then print "Hridoy" ,if any number divided by both number 3 and 5 print "JahidulHridoy"
            //for(int i=1; i <= 100; i++)
            //{
            //    if(i%3==0 && i % 5 == 0)
            //    {
            //        Console.Write("JahidulHasan");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Jahid");
            //    }
            //    else if(i %5==0)
            //    {
            //        Console.WriteLine("Hridoy");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("you can check any number!!!" +
            //    "");
            //Console.Write("Enter a number :");
            //int i = int.Parse(Console.ReadLine());


            //for ( i =1; i <= 100; i++)
            //{
            //if (i % 3 == 0 && i % 5 == 0)
            //{
            //    Console.WriteLine("Jahidul hasan Hridoy..");

            //}
            //else if (i % 5 == 0)
            //{
            //    Console.WriteLine("Hasan");
            //}
            //else if (i % 3 == 0)
            //{
            //    Console.WriteLine("Jahid");
            //}
            //else
            //{
            //    Console.WriteLine(i);
            //}

            //}
            Console.Write("Enter a number :");
            int i = int.Parse(Console.ReadLine());

            if (i % 3==0 && i % 5==0)
            {
                Console.WriteLine("Jahidul hasan ");
            }
            else if(i % 3 == 0)
            {
                Console.WriteLine("jahidul");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine("Hasan");
            }
            else
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}
