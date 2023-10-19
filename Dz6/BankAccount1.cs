using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz6
{
    class BankAccount1
    {
        public enum BankAccountType
        {
            current,
            savings
        }
        private int _accountNumber;
        private double _balance;
        private BankAccountType _bat;
        public BankAccount1(int accountNumber, double balance, BankAccountType bat)
        {
            _accountNumber = accountNumber;
            _balance = balance;
            _bat = bat;
        }
        public BankAccount1() { }
        public void SetAccountNumber(int accNum)
        {
            _accountNumber = accNum;
        }
        public int GetAccountNumber()
        {
            return _accountNumber;
        }
        public void SetBalance(double balance)
        {
            _balance = balance;
        }
        public double GetBalance()
        {
            return _balance;
        }
        public void SetBankAccountType(int bat)
        {
            if (bat == 1)
            {
                _bat = BankAccountType.current;
            }
            else if (bat == 2)
            {
                _bat = BankAccountType.savings;
            }
            else
            {
                Console.WriteLine("\nНеверный выбор. Устанавлиеватся значение по умолчанию");
            }
        }
        public BankAccountType GetBankAccountType()
        {
            return _bat;
        }
        public void Print()
        {
            Console.WriteLine($"\nНомер счета: {_accountNumber}\nБаланс: {_balance}\nТип: {_bat}");
        }
    }
}
