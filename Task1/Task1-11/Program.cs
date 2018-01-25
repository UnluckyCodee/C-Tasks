using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            string[] words = input.Split(GetSeparators(input), StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            for (int i = 0; i < words.Length; i++)
            {
                sum += words[i].Length;
            }
            
            Console.WriteLine($"Средняя длина строки:  {sum/words.Length}");
            Console.ReadLine();
        }

        private static char[] GetSeparators(string input)
        {
            char[] output = new char[input.Length]; 
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsPunctuation(input[i]) || char.IsSeparator(input[i]))
                {
                    output[i] = input[i];
                }
            }
            return output;
        }

    }
}
