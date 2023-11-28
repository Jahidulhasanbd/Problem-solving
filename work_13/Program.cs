using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int k = 0;
            Console.WriteLine("Enter The Value To Draw A Rectangle Shape:");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
                k += 2;
            }
            Console.ReadKey();
        }
    }
}
