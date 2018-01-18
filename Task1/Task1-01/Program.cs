using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                Console.WriteLine($"Площадь прямоугольника: {a * b}");   
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
