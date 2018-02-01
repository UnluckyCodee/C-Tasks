using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_addition_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string words = Console.ReadLine();
            Console.WriteLine($"Обработанная строка:  {Rep(words)}");
        }

        private static string Rep(string words)
        {
            char[] seps = { ' ' };
            string[] parts = words.Split(seps, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parts.Length; i++)
            {
                words = String.Join(" ", parts);
            }
            return words;
        }
    }
}
