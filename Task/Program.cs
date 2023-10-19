using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа реализует все принципы ООП");
            Student student1 = new Student();
            Student student2 = new Student();

            Teacher teacher1 = new Teacher();
            Console.WriteLine("Заполните данные об учителе");
            teacher1.Fill();
            teacher1.Show();
            Console.Write("\nПонизим цену за проведение класс: ");
            if (double.TryParse(Console.ReadLine(), out double money))
            {
                teacher1.PriceDecrease(money);
            }
            else
            {
                Console.WriteLine("\nНеверный ввод");
            }
            teacher1.Show();
            Console.WriteLine($"Цена за полный класс: {teacher1.FullCoursePrice()}");

            Console.WriteLine("\nЗаполните данные об учениках");
            student1.Fill();
            student2.Fill();
            student1.Show();
            student2.Show();

            Console.WriteLine("\nУвеличение денег у ученика 1");
            Console.Write("Введите сумму: ");
            if (double.TryParse(Console.ReadLine(), out money))
            {
                student1.AddMoney(money);
            }
            else
            {
                Console.WriteLine("\nНеверный ввод");
            }

            Console.WriteLine("\nУменьшение денег у ученика 2");
            Console.Write("Введите сумму: ");
            if (double.TryParse(Console.ReadLine(), out money))
            {
                student2.RemoveMoney(money);
            }
            else
            {
                Console.WriteLine("\nНеверный ввод");
            }

            Console.WriteLine("\nПеренос записи на класс у ученика 1");
            Console.Write("Введите на сколько часов перенести: ");

            if (int.TryParse(Console.ReadLine(), out int hours))
            {
                student1.AddHoursToRegistration(hours);
            }
            else
            {
                Console.WriteLine("\nНеверный ввод");
            }

            student1.Show();
            student2.Show();

            Console.WriteLine("\nПроверка может ли ученик попасть на класс");
            if (student1.CanSignUp(teacher1))
            {
                teacher1.ListOfStudents.Add(student1);
                Console.WriteLine("\nУченик 1 попал на класс");
            }
            else
            {
                Console.WriteLine("\nУченик 1 не попал на класс");
            }
            if (student2.CanSignUp(teacher1))
            {
                teacher1.ListOfStudents.Add(student2);
                Console.WriteLine("Ученик 2 попал на класс");
            }
            else
            {
                Console.WriteLine("Ученик 2 не попал на класс");
            }

            Console.WriteLine("\nСписок учеников:");
            foreach (var i in teacher1.ListOfStudents)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine($"\nУчитель всего получит за класс: {teacher1.TotalEarned()}");

            Console.WriteLine("\nЗаполните данные о блюде");
            Food food1 = new Food();
            food1.Fill();
            food1.Finish();
            food1.Show();

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
