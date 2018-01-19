using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_06
{
    class Program
    {
        [Flags]
        enum Actions : byte
        {
            None = 0,
            bold = 1,
            italic = 2,
            underline = 4
        }

        static void Main(string[] args)
        {
            Actions a = Actions.None;
            while (true)
            {
                Console.WriteLine($"Параметры записи: {a}");
                Console.WriteLine("Введите:");
                Console.WriteLine("1: Bold");
                Console.WriteLine("2: Italic");
                Console.WriteLine("3: Underline");
                int input;
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Ошибка");
                }
                else {
                    switch (input) {
                        case 1:
                            a ^= Actions.bold;
                            break;
                        case 2:
                            a ^= Actions.italic;
                            break;
                        case 3:
                            a ^= Actions.underline;
                            break;
                        default:
                            Console.WriteLine("lol");
                            break;
                    }
                }
            }
        }
    }
}