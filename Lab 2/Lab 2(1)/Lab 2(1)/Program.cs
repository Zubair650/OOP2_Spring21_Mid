﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int i;
            Console.WriteLine("Even Numbers are: ");
            for (i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
