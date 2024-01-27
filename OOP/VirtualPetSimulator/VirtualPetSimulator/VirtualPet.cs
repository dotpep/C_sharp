using System.ComponentModel;
using System.Xml.Linq;
using static System.Console;

namespace VirtualPetSimulator
{
    class VirtualPet : Pet
    {
        private PetMood _moodState = PetMood.Unhappy;
        private int _level = 1;
        private int _experiencePoint = 0;
        private readonly int _maxExperiencePoint = 40;

        public PetMood MoodState
        {
            get { return _moodState; }
            private set { _moodState = value; }
        }

        public int Level
        {
            get { return _level; }
            private set { _level = value; }
        }

        public int ExperiencePoint
        {
            get { return _experiencePoint; }
            private set { _experiencePoint = value; }
        }

        // A constructor that takes no parameters and sets some of the fields to default values.
        public VirtualPet()
            : base(name: "Unknown", species: "Unknown", ageInDays: 1)
        {
            IsAwake = true;
        }

        // A constructor that takes parameters and uses them to set the fields.
        public VirtualPet(string petName, string petSpecies, int petAge) 
            : base(petName, petSpecies, petAge)
        {
            IsAwake = false;
        }

        // Private Methods
        private void CheckLevelUp()
        {
            if (_experiencePoint >= _maxExperiencePoint)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            _level++;
            _experiencePoint = 0;
            ChangePetMoodsState();
            WriteLine($"{Name} leveled up to {_level}!");
        }

        private void ChangePetMoodsState()
        {
            MoodState = PetMood.Happy;
        }

        // Method defination:
        public void Greet()
        {
            WriteLine($"My name is {Name}!");
            WriteLine($"I am {AgeInDays} days old.");
            WriteLine($"Is awake? {IsAwake}.");
        }

        public void PetInfo()
        {
            WriteLine($"Mood: {MoodState}");
            WriteLine($"Experience: {_experiencePoint}/{_maxExperiencePoint}");
            WriteLine($"Level: {_level}");
        }


        public void Sleep()
        {
            IsAwake = false;
            WriteLine($"{Name} is now happily snoring... Zzzzzz");
            _experiencePoint += 15;
            CheckLevelUp();
        }

        public void Awake()
        {
            IsAwake = true;
            WriteLine($"{Name} glad to see you!");
            _experiencePoint += 10;
            CheckLevelUp();
        }

        // One input (a.k.a a parameter)
        public void Eat(string foodName)
        {
            WriteLine($"{Name} is now eating {foodName}.");
            _experiencePoint += 20;
            CheckLevelUp();
        }
    }
}
