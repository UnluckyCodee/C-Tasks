using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_08
{
    class Program
    {
        private static Random rand = new Random();

        public static int[,,] GenerateArray()
        {
            int x;
            int y;
            int z;

            do
            {
                Console.WriteLine("Введите размерность массива по X: ");
                x = int.Parse(Console.ReadLine());
                if (x <= 0)
                {
                    Console.Write("Некорректный ввод");
                }
            }
            while (x <= 0);


            do
            {
                Console.Write("Введите размерность массива по Y: ");
                y = int.Parse(Console.ReadLine());
                if (y <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            while (y <= 0);

            do
            {
                Console.Write("Введите размерность массива по Z: ");
                z = int.Parse(Console.ReadLine());
                if (z <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            while (z <= 0);

            int[,,] arr = new int[x, y, z];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int b = 0; b < z; b++)
                    {
                        arr[i, j, b] = rand.Next(-50, 50);
                    }
                }
            }
            return arr;
        }
        private static void WriteArray(int[,,] arr)
        {
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int b = 0; b <= arr.GetUpperBound(2); b++)
                        Console.WriteLine($"Array[{i},{j},{b}]: {arr[i, j, b]}");
                }
            }
        }
        private static void RemovePositive(int[,,] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int b = 0; b <= arr.GetUpperBound(2); b++)
                    {
                        if (arr[i, j, b] > 0)
                        {
                            arr[i, j, b] = 0;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[,,] arr = GenerateArray();
            WriteArray(arr);
            RemovePositive(arr);
            WriteArray(arr);
            Console.ReadKey();
        }
    }
}