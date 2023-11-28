using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Write a number :");
            //int num= int.Parse(Console.ReadLine());
            //switch (num)
            //{
            //    case 1:
            //        Console.WriteLine("it is January.");
            //        break;
            //    case 2:
            //        Console.WriteLine("it is februrary");
            //        break;
            //    case 3:
            //        Console.WriteLine("it is March");
            //        break;
            //    case 4:
            //        Console.WriteLine("it is April");
            //        break;
            //    case 5:
            //        Console.WriteLine("it is May");
            //        break;
            //    case 6:
            //        Console.WriteLine("it is June");
            //        break;
            //    case 7:
            //        Console.WriteLine("it is July");
            //        break;
            //    case 8:
            //        Console.WriteLine("it is Agust");
            //        break;
            //    case 9:
            //        Console.WriteLine("it is September");
            //        break;
            //    case 10:
            //        Console.WriteLine("it is October");
            //        break;
            //    case 11:
            //        Console.WriteLine("it is November");
            //        break;
            //    case 12:
            //        Console.WriteLine("it is December");
            //        break;
            //    default:
            //        Console.WriteLine("Please enter 1 to 12 number");
            //        break;
            //}

            Console.Write("Enter a Number for find day: ");
            int num=int.Parse(Console.ReadLine());
            switch (num){
                case 1:
                    Console.WriteLine("it is saturday");
                    break;
                    case 2:
                    Console.WriteLine("it is sunday");
                    break;
                case 3:
                    Console.WriteLine("it is monday");
                    break;
                case 4:
                    Console.WriteLine("it is tuesday");
                    break;
                case 5:
                    Console.WriteLine("it is wednesday");
                    break;
                case 6:
                    Console.WriteLine("it is thursday");
                    break;
                case 7:
                    Console.WriteLine("it is friday");
                    break;
                default:
                    Console.WriteLine("please enter 1-7 for find day");
                    break;

            }
               
            Console.ReadKey();
        }
    }
}
