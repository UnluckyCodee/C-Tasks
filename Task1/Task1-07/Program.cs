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

        public static int[] GenerateArray(int n)
        {
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
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
        static void Main(string[] args)
        {
            int[] arr = GenerateArray(10);
            WriteArray(arr);           
            Console.ReadLine();
        }
    }
}
