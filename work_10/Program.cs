﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a factorial Number N
            //var temp = 1;
            //for(var i = 1; i <= 7; i++)
            //{
            //    temp = temp * i;
            //}
            //Console.WriteLine(temp); 

            var vir = 1;
            for(int r=1; r <=6; r++)
            {
                vir = vir * r;
            }
            Console.WriteLine(vir);
            Console.ReadKey();
        }
      
    }
}
