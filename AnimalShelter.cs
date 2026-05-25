using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP.Ex1
{
    public class AnimalShelter
    {
        private List<Animal> _animals; 
        public AnimalShelter()
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
            Console.WriteLine($"Added: {animal.Name}");
        }
        public void DisplayAll()
        {
            foreach (Animal animal in _animals)
            {
                animal.DisplayInfo();
                Console.WriteLine("-------------------");
            }
        }
        public int Count()
        {
            return _animals.Count; 
        }
    }
}
