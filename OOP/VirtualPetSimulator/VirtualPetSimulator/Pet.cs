using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetSimulator
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public int AgeInDays { get; set; }
        public string Species { get; set; }
        public bool IsAwake { get; set; }

        public Pet(string name, string species, int ageInDays)
        {
            Name = name;
            Species = species;
            AgeInDays = ageInDays;
        }

        public void Greet()
        {
            Console.WriteLine($"My name is {Name}!");
            Console.WriteLine($"I am {AgeInDays} days old.");
            Console.WriteLine($"Is awake? {IsAwake}.");
        }
    }
}
