using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Teacher : Person
    {
        public enum Skills
        {
            Любитель = 1,
            Профессионал,
            Мастер
        }
        private Skills _skill;
        private string _placeOfWork;
        private double _coursePriceOnHour;
        private double _courseHours;
        private string _courseName;
        List<Student> listOfStudent;
        public Skills Skill
        {
            get
            {
                return _skill;
            }
            set
            {
                _skill = value;
            }
        }
        public string PlaceOfWork
        {
            get
            {
                return _placeOfWork;
            }
            set
            {
                _placeOfWork = value;
            }
        }
        public double CoursePriceOnHour
        {
            get
            {
                return _coursePriceOnHour;
            }
            set
            {
                _coursePriceOnHour = value;
            }
        }
        public double CourseHours
        {
            get
            {
                return _courseHours;
            }
            set
            {
                _courseHours = value;
            }
        }
        public string CourseName
        {
            get
            {
                return _courseName;
            }
            set
            {
                _courseName = value;
            }
        }
        public List<Student> ListOfStudents
        {
            get
            {
                return listOfStudent;
            }
            set
            {
                listOfStudent = value;
            }
        }
        public Teacher(string name, string surname, int age, Genders gender, Skills skill, string placeOfWork, double coursePrice, double courseHours, string courseName) : base(name, surname, age, gender)
        {
            Skill = skill;
            PlaceOfWork = placeOfWork;
            CoursePriceOnHour = coursePrice;
            CourseHours = courseHours;
            CourseName = courseName;
            listOfStudent = new List<Student>();
        }
        public Teacher() : base(null, null, 0, Genders.Мужской) 
        {
            listOfStudent = new List<Student>();
        }

        public void PriceIncrease(double price)
        {
            CoursePriceOnHour += price;
        }
        public void PriceDecrease(double price)
        {
            if (CoursePriceOnHour < price)
            {
                Console.WriteLine("\nНеверное значение");
            }
            else
            {
                CoursePriceOnHour -= price;
            }
        }
        public double FullCoursePrice()
        {
            return CourseHours * CoursePriceOnHour;
        }
        public double TotalEarned()
        {
            return FullCoursePrice() * listOfStudent.Count;
        }
        public override void Show()
        {
            Console.WriteLine($"\nИнформация об учителе\nИмя: {Name}\nФамилия: {Surname}\nВозраст: {Age}\nПол: {Gender}\nУровень мастерства: {Skill}\nМесто работы: {PlaceOfWork}" +
                $"\nНазвание класса: {CourseName}\nЦена класса: {CoursePriceOnHour} за час\nДлительность класса: {CourseHours} ч.");
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
                Console.WriteLine("\nНеверный ввод. Установка по умолчанию");
            }
            Console.Write("Введите уровень мастерства(1-3): ");
            if (int.TryParse(Console.ReadLine(), out int skill))
            {
                if (skill == 1)
                {
                    Skill = Skills.Любитель;
                }
                else if (skill == 2)
                {
                    Skill = Skills.Профессионал;
                }
                else if (skill == 3)
                {
                    Skill = Skills.Мастер;
                }
                else
                {
                    Console.WriteLine("\nНеверный ввод. Установка по умолчанию");
                }
            }
            Console.Write("Введите место работы: ");
            PlaceOfWork = Console.ReadLine();
            Console.Write("Введите название курса: ");
            CourseName = Console.ReadLine();
            Console.Write("Введите цену курса за час: ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                CoursePriceOnHour = price;
            }
            else
            {
                Console.WriteLine("\nНеверный ввод. Установка по умолчанию");
            }
            Console.Write("Введите длительность курса: ");
            if (double.TryParse(Console.ReadLine(), out double time))
            {
                CourseHours = time;
            }
            else
            {
                Console.WriteLine("\nНеверный ввод. Установка по умолчанию");
            }
        }
    }
}
