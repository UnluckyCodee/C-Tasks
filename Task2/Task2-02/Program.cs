using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle_1 = new Triangle();
            Triangle triangle_2 = new Triangle(5, 5, 5);
            Console.WriteLine($"Треугольник со сторонами ({triangle_1.A},{triangle_1.B},{triangle_1.C}) Имеет площадь ({triangle_1.Area}) И периметр ({triangle_1.Perimeter}) ");
            Console.WriteLine($"Треугольник со сторонами ({triangle_2.A},{triangle_2.B},{triangle_2.C}) Имеет площадь ({triangle_2.Area}) И периметр ({triangle_2.Perimeter}) ");

        }
    }
}
