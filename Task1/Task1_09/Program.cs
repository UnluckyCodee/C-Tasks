using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_09
{
    class Program
    {
        private static Random rand = new Random();

        public static int[] GenerateArray()
        {
            int n;

            do
            {
                Console.Write("Введите количество элементов: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
            while (n <= 0);

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
            }
            return arr;
        }
        private static void WriteArray(int[] arr)
        {
            Console.WriteLine("Элементы массива:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
        private static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] arr = GenerateArray();
            WriteArray(arr);
            Sum(arr);
            Console.WriteLine($"Сумма неотрицательных элементов массива: {Sum(arr)}");
            Console.ReadKey();
        }
    }
}
