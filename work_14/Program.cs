using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string Masum = "I am a khicca masum";
            //Console.WriteLine("Original type is : "+Masum);
            //string kiccha = "";
            //for(int x=Masum.Length -1; x>=0; x--)
            //{
            //    kiccha += Masum[x];
            //}
            //Console.WriteLine("Reverse is :" +kiccha);

            string input = "he is a liar";
            Console.WriteLine("The input is :"+input);
            string output = "";
            for (int q= input.Length-1; q >= 0; q--)
            {
                output += input[q];
            }
            Console.WriteLine("The output is " + output);

            Console.ReadKey();
        }
    }
}
