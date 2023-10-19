using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.1");
            Console.WriteLine("Программа создает объект класса банк");
            int accNum, type;
            double balance;
            BankAccount1 ba = new BankAccount1();
            Console.Write("\nВведите номер счета: ");
            if (int.TryParse(Console.ReadLine(), out accNum))
            {
                ba.SetAccountNumber(accNum);
                Console.Write("Введите баланс: ");
                if (double.TryParse(Console.ReadLine(), out balance))
                {
                    ba.SetBalance(balance);
                    Console.WriteLine("Введите тип аккаунта: \n1) Текущий \n2) Сберегательный");
                    if (int.TryParse(Console.ReadLine(), out type))
                    {
                        ba.SetBankAccountType(type);
                        Console.WriteLine($"\nНомер счета: {ba.GetAccountNumber()}\nБаланс: {ba.GetBalance()}\nТип аккаунта: {ba.GetBankAccountType()}");
                    }
                    else
                    {
                        Console.WriteLine("\nВы ввели не число");
                    }
                }
                else
                {
                    Console.WriteLine("\nВы ввели не число");
                }
            }
            else
            {
                Console.WriteLine("\nВы ввели не число");
            }

            Console.WriteLine("\nУпражнение 7.2");
            Console.WriteLine("Программа создает объект класса банк, номер генерируется сам");

            BankAccount2 ba2 = new BankAccount2(2000, BankAccount2.BankAccountType.current);
            BankAccount2 ba3 = new BankAccount2();

            Console.Write("Введите баланс: ");
            if (double.TryParse(Console.ReadLine(), out balance))
            {
                ba3.SetBalance(balance);
                Console.WriteLine("Введите тип аккаунта: \n1) Текущий \n2) Сберегательный");
                if (int.TryParse(Console.ReadLine(), out type))
                {
                    ba3.SetBankAccountType(type);
                }
                else
                {
                    Console.WriteLine("\nВы ввели не число");
                }
            }
            else
            {
                Console.WriteLine("\nВы ввели не число");
            }

            ba2.Print();
            ba3.Print();

            Console.WriteLine("\nУпражнение 7.3");
            Console.WriteLine("Программа создает объект класса банк, номер генерируется сам, можно увеличить и уменьшить баланс");

            BankAccount3 ba4 = new BankAccount3();
            Console.Write("Введите баланс: ");
            if (double.TryParse(Console.ReadLine(), out balance))
            {
                ba4.SetBalance(balance);
                Console.WriteLine("Введите тип аккаунта: \n1) Текущий \n2) Сберегательный");
                if (int.TryParse(Console.ReadLine(), out type))
                {
                    ba4.SetBankAccountType(type);
                    ba4.Print();

                    Console.WriteLine("\nВыберите действие: \n1) Добавить деньги \n2) Снять деньги");
                    string choice = Console.ReadLine();
                    double money;
                    if (choice == "1")
                    {
                        Console.Write("\nВведите сумму: ");
                        if (double.TryParse(Console.ReadLine(), out money))
                        {
                            ba4.AddBalance(money);
                            ba4.Print();
                        }
                        else
                        {
                            Console.WriteLine("\nВы ввели не число");
                        }
                    }
                    else if (choice == "2")
                    {
                        Console.Write("\nВведите сумму: ");
                        if (double.TryParse(Console.ReadLine(), out money))
                        {
                            ba4.WithdrawBalance(money);
                            ba4.Print();
                        }
                        else
                        {
                            Console.WriteLine("\nВы ввели не число");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nНеверный выбор");
                    }
                }
                else
                {
                    Console.WriteLine("\nВы ввели не число");
                }
            }
            else
            {
                Console.WriteLine("\nВы ввели не число");
            }

            Console.WriteLine("\nДом. задание 7.1");
            Console.WriteLine("Программа создает объект класса здание");
            Building build1 = new Building();
            Building build2 = new Building(120, 37, 256, 4);
            Console.Write("\nВведите высоту здания: ");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                build1.SetHeight(height);
                Console.Write("\nВведите кол-во этажей: ");
                if (int.TryParse(Console.ReadLine(), out int floors))
                {
                    build1.SetNumOfFloors(floors);
                    Console.Write("\nВведите кол-во квартир: ");
                    if (int.TryParse(Console.ReadLine(), out int aparts))
                    {
                        build1.SetNumOfAparts(aparts);
                        Console.Write("\nВведите кол-во подъездов: ");
                        if (int.TryParse(Console.ReadLine(), out int entrances))
                        {
                            build1.SetNumOfEntrances(entrances);
                            build1.Print();
                            Console.WriteLine($"Высота этажа: {build1.HeightOfFloor()}\nКол-во квартир в подъезде: {build1.NumOfApartInEntrances()}" +
                                $"\nКол-во квартир на этаже: {build1.NumOfApartOnFloor()}");
                        }
                        else
                        {
                            Console.WriteLine("\nВы ввели не число");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nВы ввели не число");
                    }
                }
                else
                {
                    Console.WriteLine("\nВы ввели не число");
                }
            }
            else
            {
                Console.WriteLine("\nВы ввели не число");
            }

            build2.Print();
            Console.WriteLine($"Высота этажа: {build2.HeightOfFloor()}\nКол-во квартир в подъезде: {build2.NumOfApartInEntrances()}" +
                                $"\nКол-во квартир на этаже: {build2.NumOfApartOnFloor()}");

            Console.WriteLine("\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
