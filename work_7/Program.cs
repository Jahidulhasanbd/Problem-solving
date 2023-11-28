using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-100  find out the even number 
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} number is not a even number",i);
            //    }
            //}

            //1-100  find out the even number 
            for (int i=0; i <= 100; i++)
            {
                if(i % 2==0)
                {
                    Console.WriteLine("{0} is a even number..",i);
                }
                else
                {
                    Console.WriteLine("{0} is not a even number..", i);
                }
            }
            Console.ReadKey();
        }
    }
}
