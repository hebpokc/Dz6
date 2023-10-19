using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    abstract class Person
    {
        public enum Genders
        {
            Мужской,
            Женский
        }
        protected string name;
        protected string surname;
        protected int age;
        protected Genders gender;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public Genders Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        public Person(string name, string surname, int age, Genders gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public abstract void Show();
        public abstract void Fill();
    }
}
