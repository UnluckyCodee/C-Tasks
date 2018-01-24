using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод Размерности:");

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int[,,] arr;
            arr = new int[x, y, z];
            double[,,] Array = new double[x, y, z];
            {
                Console.WriteLine("Ввод Элемента:");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        for (int b = 0; b < z; b++)
                        {
                            Console.Write("Array[" + i + "," + j + "," + b + "]: ");
                            Array[i, j, b] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        for (int b = 0; b < z; b++)
                        {
                            if (Array[i, j, b] > 0)
                            {
                                Array[i, j, b] = 0;
                            }
                            Console.WriteLine($"Array: {Array[i, j, b]}");

                        }

                    }
                }
                Console.ReadKey();
            }
        }
    }
}
