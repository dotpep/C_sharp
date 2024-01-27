using static System.Console;

namespace VirtualPetSimulator
{
    class VirtualPet
    {
        // Field
        // public   = access modifier
        // string   = type
        // Name     = identifier
        // PascalCase
        public string FullName;
        public int Age;
        public string Species;

        public bool IsAwake;
        private int ExperiencePoints;

        // Constructor
        public VirtualPet(string petName, int petAge, string petSpecies, bool petIsAwake)
        {
            FullName = petName;
            Age = petAge;
            Species = petSpecies;
            IsAwake = petIsAwake;
        }

        // Method defination:
        public void Greet()
        {
            WriteLine($"My name is {FullName}!");
            WriteLine($"I am {Age} years old.");
            WriteLine($"Is awake? {IsAwake}.");
        }

        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"{FullName} is now happily snoring... Zzzzzz");
        }

        // One input (a.k.a a parameter)
        public void Eat(string foodName)
        {
            WriteLine($"{FullName} is now eating {foodName}.");
        }
    }
}
