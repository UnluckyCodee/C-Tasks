using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_03
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Ivanov", "Ivan", "Ivanovich", new DateTime(1995, 8, 19));
            Console.WriteLine($"Иия {user.Name} Фамилия {user.Surname} Отчество {user.Patronymic} Дата рождения ({user.Birthday.ToString("yyyy/MM/dd")})");
            user.Birthday = new DateTime(1119, 7, 13);
        }
    }
}
