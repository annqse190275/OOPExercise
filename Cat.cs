using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP.Ex1
{
    public class Cat : Animal
    {
        private bool _isIndoor; 
        public bool IsIndoor
        {
            get => _isIndoor;
            set => _isIndoor = value; 
        }
        public Cat(string name, int age, bool isIndoor) : base(name, age)
        {
            _isIndoor = isIndoor;
        }

        public override string MakeSound()
        {
            return "Meow!";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Is Indoor: {_isIndoor}, Sound: {MakeSound()}");
        }
    }
}
