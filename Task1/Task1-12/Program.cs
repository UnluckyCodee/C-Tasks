using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string firstString = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string secondString = Console.ReadLine();

            Console.WriteLine($"Результирующая строка: {Duplicate(firstString, secondString)}");
        }
        private static string Duplicate(string firstString, string secondString)
        {
            var sb = new StringBuilder(2 * firstString.Length);
            {
                for (int i = 0; i < firstString.Length; i++)
                {
                    if (!secondString.Contains(firstString[i]))
                    {
                        sb.Append(firstString[i]);
                    }
                    else
                    {
                        sb.Append(firstString[i]);
                        sb.Append(firstString[i]);
                    }
                }
            }

            return sb.ToString();
        }

    }
}