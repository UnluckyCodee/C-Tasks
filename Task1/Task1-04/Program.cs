using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int n = 1; n <= N; n++)
            {
                for (int n1 = 1; n1 <= n; n1++)
                {
                    Console.Write(new string(' ', N - n1));
                    Console.WriteLine(new string('*', 2 * n1 - 1));
                }
            }
        }
    }
}