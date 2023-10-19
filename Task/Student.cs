using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Student : Person
    {
        private double _money;
        private int _phoneNumber;
        private DateTime _registrationTime;

        public double Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
            }
        }
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }
        public DateTime RegistrationTime
        {
            get
            {
                return _registrationTime;
            }
            set
            {
                _registrationTime = value;
            }
        }
        public Student(string name, string surname, int age, Genders gender, double money, int phoneNumber, DateTime date) : base(name, surname, age, gender)
        {
            Money = money;
            PhoneNumber = phoneNumber;
            RegistrationTime = date;
        }
        public Student() : base(null, null, 0, Genders.Мужской) { }
        public void AddMoney(double money)
        {
            Money += money;
        }
        public void RemoveMoney(double money)
        {
            if (Money < money)
            {
                Console.WriteLine("\nНеверное значение. Сумма не может быть больше нынешней");
            }
            else
            {
                Money -= money;
            }
        }
        public void AddHoursToRegistration(int hours)
        {
            RegistrationTime = RegistrationTime.AddHours(hours);
        }
        public bool CanSignUp(Teacher a)
        {
            return Money >= a.CoursePriceOnHour ? true : false;
        }
        public override void Show()
        {
            Console.WriteLine($"\nИнформация об ученике\nИмя: {Name}\nФамилия: {Surname}\nВозраст: {Age}\nПол: {Gender}\nКоличество денег: {Money}\nНомер телефона: {PhoneNumber}" +
                $"\nВремя записи на курс: {RegistrationTime}");
        }
        public override void Fill()
        {
            Console.Write("\nВведите имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            Surname = Console.ReadLine();
            Console.Write("Введите возраст: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("\nНеверный формат данных. Установка по умолчанию");
            }
            Console.Write("Введите кол-во денег: ");
            if (double.TryParse(Console.ReadLine(), out double money))
            {
                Money = money;
            }
            else
            {
                Console.WriteLine("\nНеверный формат данных. Установка по умолчанию");
            }
            Console.Write("Введите номер телефона: ");
            if (int.TryParse(Console.ReadLine(), out int phone))
            {
                PhoneNumber = phone;
            }
            else
            {
                Console.WriteLine("\nНеверный формат данных. Установка по умолчанию");
            }
            Console.Write("Введите день записи: ");
            if (int.TryParse(Console.ReadLine(), out int day))
            {
                Console.Write("Введите месяц записи: ");
                if (int.TryParse(Console.ReadLine(), out int month))
                {
                    Console.Write("Введите час записи: ");
                    if (int.TryParse(Console.ReadLine(), out int hour))
                    {
                        Console.Write("Введите минуты записи: ");
                        if (int.TryParse(Console.ReadLine(), out int min))
                        {
                            RegistrationTime = new DateTime(2023, month, day, hour, min, 0);
                        }
                        else
                        {
                            Console.WriteLine("\nНеверный формат данных. Установка по умолчанию");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nНеверный формат данных. Установка по умолчанию");
                    }
                }
                else
                {
                    Console.WriteLine("\nНеверный формат данных. Установка по умолчанию");
                }
            }
            else
            {
                Console.WriteLine("\nНеверный формат данных. Установка по умолчанию");
            }
        }
    }
}
