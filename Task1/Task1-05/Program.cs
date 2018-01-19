using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_05
{
    class Program
    {
        static void Main(string[] args)
        { int a1 = 5;
            int b1 = 3;
            int c1 = 15;
            int n = 1000;
            int sum1 = ((((2 * a1) + (a1 * ((n / a1) - 1))) / 2) * (n / a1));
            int sum2 = ((((2 * b1) + (b1 * ((n / b1) - 1))) / 2) * (n / b1));
            int sum3 = ((((2 * c1) + (c1 * ((n / c1) - 1))) / 2) * (n / c1));
            int sum4 = ((sum1 + sum2) - sum3);
            {
                Console.WriteLine($"Результат: {sum4}");
            }
        } 
      
    }

}
