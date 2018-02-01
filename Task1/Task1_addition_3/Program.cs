using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_addition_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string words = Console.ReadLine();
            if (IsPalindrom(words))
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();
        }

        private static bool IsPalindrom(string words)
        {
            int i = 0;
            for (i = 0; i < words.Length / 2; i++)
            {
                if (words[i] != words[words.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}