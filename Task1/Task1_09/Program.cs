using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_09
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            double[] Array = new double[n];

            Console.WriteLine("Ввод Элемента:");
            { 
            for (int i = 0; i < n; i++)
            
                 Array[i] = double.Parse(Console.ReadLine());
                double Sum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (Array[i] > 0)
                    {
                        Sum += Array[i];
                    }
                
        }
         Console.WriteLine($"Сумма неотрицательных элементов массива = { Sum }");
         Console.ReadKey();
             }
        }
    }
}
