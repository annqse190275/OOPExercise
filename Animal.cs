using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP.Ex1
{
    public abstract class Animal
    {
        private string _name;
        private int _age;

        public string Name
        {
            get => _name;
            set => _name = value; 
        }
        public int Age
        {
            get => _age; 
            set => _age = (value >= 0) ? value : throw new ArgumentException("Age cannot be negative.");

        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age; // THAY VI DUNG _age = age
                       // TA SU DUNG PROPERTY DE GOI DEN SETTER CUA
                       // AGE DE KIEM TRA GIA TRI TRUOC KHI GAN
        }

        public abstract string MakeSound(); 
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}, Age: {_age}");
        }
    }
}
