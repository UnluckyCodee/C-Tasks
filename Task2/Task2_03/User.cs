using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_03
{
    class User
    {
        private string name, surname, patronymic;
        private DateTime birthday;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                CheckNotNull(value, this.surname, this.patronymic);
                this.name = value;
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }
            set
            {
                CheckNotNull(this.name, value, this.patronymic);
                this.surname = value;
            }
        }

        public string Patronymic
        {
            get
            {
                return this.patronymic;
            }
            set
            {
                CheckNotNull(this.name, this.surname, value);
                this.patronymic = value;
            }
        }

        private void CheckNotNull(string name, string surname, string patronymic)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(patronymic))
            {
                throw new ArgumentException("ФИО не должно содержать пустых значений");
            }
        }

        public DateTime Birthday
        {
            get
            {
                return this.birthday;
            }
            set
            {
                int age = CalculateDifference(value, DateTime.Now);
                if (age > 150)
                {
                    throw new ArgumentException("Данные введены некорректно, проверьте год рождения");
                }
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата рождения не может быть больше сегодняшней");
                }
                this.birthday = value;
            }
        }

        private int CalculateDifference(DateTime start, DateTime end)
        {
            int age = end.Year - start.Year;
            if (start > DateTime.Now.AddYears(-age));
            {
                age--;
            }
            return age;
        }

        public int Age => CalculateDifference(this.birthday, DateTime.Now);

        public User(string name, string surname, string patronymic, DateTime birthday)
        {
            CheckNotNull(name, surname, patronymic);
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.Birthday = birthday;
        }
    }
}
