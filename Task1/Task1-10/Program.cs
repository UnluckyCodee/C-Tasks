﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_10
{
    class Program
    {
        private static Random rand = new Random();

        public static int[,] GenerateArray()
        {
            Console.WriteLine("Введите размерность массива: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] arr = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    arr[i, j] = rand.Next(-50, 50);
                }
            }
            return arr;
        }
        private static void WriteArray(int[,] arr)
        {
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                    Console.WriteLine($"Array[{i},{j}]: {arr[i, j]}");
            }
        }
        private static int Sum(int[,] arr)
        {

            int sum = 0;
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = i % 2; j <= arr.GetUpperBound(1); j += 2)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[,] arr = GenerateArray();
            WriteArray(arr);
            Sum(arr);
            Console.WriteLine($"Сумма элементов на четных позициях: {Sum(arr)}");
            Console.ReadKey();
        }
    }
}
