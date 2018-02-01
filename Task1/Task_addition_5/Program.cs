using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_addition_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string words = Console.ReadLine();
            Console.WriteLine($"Сумма символов верхних регистров {SumUpReg(words)} \n Сумма символов нижних регистров {SumLowReg(words)}");
        }

        private static int SumUpReg(string words)
        {
            int sum = 0;
            char[] output = new char[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i]))
                {
                    sum++;
                }
            }
            return sum;
        }

        private static int SumLowReg(string words)
        {
            int sum = 0;
            char[] output = new char[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsLower(words[i]))
                {
                    sum++;
                }
            }
            return sum;
        }

    }
}
