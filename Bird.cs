using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP.Ex1
{
    public class Bird : Animal
    {
        private bool _canFly; 
        public bool CanFly
        {
            get => _canFly;
            set => _canFly = value; 
        }
        public Bird(string name, int age, bool canFly) : base(name, age)
        {
            _canFly = canFly; 
        }

        public override string MakeSound()
        {
            return "Tweet!";
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Can Fly: {_canFly}, Sound: {MakeSound()}");
        }
    }
}
