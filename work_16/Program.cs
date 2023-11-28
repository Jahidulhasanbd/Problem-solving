using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "javascriptloop";

            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
