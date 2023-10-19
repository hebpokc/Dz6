using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Food
    {
        private string _name;
        private string _cookingTime;
        private double _weight;
        private double _calories;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string CookingTime
        {
            get
            {
                return _cookingTime;
            }
            set
            {
                _cookingTime = value;
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }
        public double Calories
        {
            get
            {
                return _calories;
            }
            set
            {
                _calories = value;
            }
        }
        public Food(string name, string cookingTime, double weight, double calories)
        {
            Name = name;
            CookingTime = cookingTime;
            Weight = weight;
            Calories = calories;
        }
        public Food() { }
        private void Prepare()
        {
            Console.WriteLine("\nГотовим продукты");
            Console.WriteLine("Моем овощи");
        }
        private void Cook()
        {
            Console.WriteLine("Нарезаем/варим...");
            Console.WriteLine($"Готовим {CookingTime} ч.");
        }
        public void Finish()
        {
            Prepare();
            Cook();
            Console.WriteLine($"{Name} готово");
        }
        public void Show()
        {
            Console.WriteLine($"\nНазвание блюда: {Name}\nВремя готовки: {CookingTime}\nВес: {Weight} г.\nКалорийность: {Calories} ккал");
        }
        public void Fill()
        {
            Console.Write("\nВведите название блюда: ");
            Name = Console.ReadLine();
            Console.Write("Введите время готовки(ч:м): ");
            CookingTime = Console.ReadLine();
            Console.Write("Введите вес: ");
            if (double.TryParse(Console.ReadLine(), out double weight))
            {
                Weight = weight;
            }
            Console.Write("Введите калорийность: ");
            if (double.TryParse(Console.ReadLine(), out double cal))
            {
                Calories = cal;
            }
        }
    }
}
