using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_01
{
   class Program
    {
        private static void Main(string[] args)
        {
            Round round = new Round();
            Round round_2 = new Round(5, 5, 12);
            Console.WriteLine($"Круг с центром в точке ({round.Center.X},{round.Center.Y}) И радиусом ({round.Radius}) Имеет длину окружности ({round.Circuit}) И площадь ({round.Area})" );
            Console.WriteLine($"Круг с центром в точке ({round_2.Center.X},{round_2.Center.Y}) И радиусом ({round_2.Radius}) Имеет длину окружности ({round_2.Circuit}) И площадь ({round_2.Area})");
        }
    }
}