﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int n = 1; n <= N; n++) 
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
