using System;
using System.Collections.Generic;
using System.Text;

namespace Exeption
{
    internal class main
    {
        static void Main(string[] args)
        {
            try
            {
                Date d = new Date(2008, 2, 30);
                Passport passport = new Passport(151654655, "David Gogins Bill", d);
                passport.ShowInfo();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка инициализации: {ex.Message}");
            }
        }

        struct Date
        {
            public int day;
            public int month;
            public int year;

            public Date(int year, int month, int day)
            {
                if (year <= 1900)
                    throw new ArgumentException("Год должен быть больше 1900");

                if (month < 1 || month > 12)
                    throw new ArgumentException("Месяц должен быть от 1 до 12");

                if (day < 1 || day > DateTime.DaysInMonth(year, month))
                    throw new ArgumentException($"День должен быть от 1 до {DateTime.DaysInMonth(year, month)} для указанного месяца");

                this.year = year;
                this.month = month;
                this.day = day;
            }
        }

        class Passport
        {
            private int passport_number;
            private string owner_name;
            private DateTime receiving_date;

            public Passport(int passport_number, string owner_name, Date receiving_date)
            {
                if (passport_number <= 0)
                    throw new ArgumentException("Номер паспорта должен быть положительным");

                if (string.IsNullOrWhiteSpace(owner_name))
                    throw new ArgumentException("ФИО владельца не может быть пустым");

                this.passport_number = passport_number;
                this.owner_name = owner_name;
                this.receiving_date = new DateTime(receiving_date.year, receiving_date.month, receiving_date.day);
            }

            public void ShowInfo()
            {
                Console.WriteLine($"Паспорт: {passport_number}");
                Console.WriteLine($"Владелец: {owner_name}");
                Console.WriteLine($"Дата выдачи: {receiving_date.ToShortDateString()}");
            }
        }
    }
    
}
