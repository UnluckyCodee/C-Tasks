using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string arg = "asdazdasfzzfdfa";
            MyString replace_1 = new MyString('a'), replace_2 = new MyString(arg), replace_3 = new MyString(arg.ToCharArray());
            // replace_3 = replace_3.Replace(replace_1, new MyString("zzz"));

            // char[] index_of_char = new char[] { 'a', 's'};

            // int i = replace_3.IndexOf(replace_1);

            // replace_3 = replace_3.Remove(3, 2);

            replace_3 = replace_3.SubString(3, 5);

            Console.WriteLine($"Исходная строка: {arg}, Вывод : {replace_3.ToString()}");
            // Console.WriteLine($"Исходная строка: {arg}, строка после удаления: {replace_3.ToString()}");
            // Console.WriteLine($"Исходная строка: {arg}, символы под замену: {replace_1.ToString()}, символы замены: zzz, Результирующая строка: {replace_3.ToString()}");
            // Console.WriteLine($"{i}");

        }
    }
}
