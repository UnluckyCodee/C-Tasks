using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_addition_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            string tmp;
            Array.Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = words.Length - 1; j > i; j--)
                {
                    if (words[j - 1].Length < words[j].Length)
                    {
                        tmp = words[j - 1];
                        words[j - 1] = words[j];
                        words[j] = tmp;
                    }
                }
            }

            foreach (string s1 in words)
            {
                Console.WriteLine(s1);
            }

        }
    }
}