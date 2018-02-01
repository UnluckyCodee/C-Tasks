using System;
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
            int N;
            do
            {
                Console.Write("Введите целое неотрицательное N: ");
                N = int.Parse(Console.ReadLine());
                if (N <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            while (N <= 0);

            for (int n = 1; n <= N; n++) 
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
