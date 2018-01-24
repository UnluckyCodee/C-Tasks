using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_07
{
    class Program
    {
        private static Random rand = new Random();

        public static int[] GenerateArray()
        {
            Console.WriteLine("Введите количество элементов: ");
            int n = int.Parse(Console.ReadLine());
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
        private static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        private static int Min(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int first, int last)
        {
            int temp;
            int x = array[first + ((last - first) / 2)];
            int i = first;
            int j = last;
            while (i <= j)
            {
                while (array[i] < x)
                {
                    i++;
                }

                while (array[j] > x)
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (i < last)
            {
                QuickSort(array, i, last);
            }

            if (first < j)
            {
                QuickSort(array, first, j);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = GenerateArray();
            WriteArray(arr);
            Console.WriteLine($"Максисмальный элемент : {Max(arr)}");
            Console.WriteLine($"Минимальный элемент : {Min(arr)}");
            QuickSort(arr);
            WriteArray(arr);
            Console.ReadLine();
        }
    }
}
