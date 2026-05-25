using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP.Ex1
{
    public class Dog : Animal
    {
        private string _breed;
        public string Breed
        {
            get => _breed; 
            set => _breed = value;
        }

        public Dog(string name, int age, string breed) : base(name, age)
        {
            _breed = breed; 
        }

        public override string MakeSound()
        {
            return "Woof!";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Breed: {_breed}, Sound: {MakeSound()}");
        }
    }
}
