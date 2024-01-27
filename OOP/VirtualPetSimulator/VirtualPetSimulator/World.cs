using static System.Console;

namespace VirtualPetSimulator
{
    internal class World
    {
        public void Run()
        {
            Title = "=== Virtual Pet Simulator ===";
            WriteLine(@" _____ _         _       _ _____     _   
|  |  |_|___ _ _| |_ ___| |  _  |___| |_ 
|  |  | |  _| | |  _| .'| |   __| -_|  _|
 \___/|_|_| |___|_| |__,|_|__|  |___|_|  ");

            WriteLine("O---------O");
            WriteLine("Welcome to the pet simulator!");
            WriteLine("O------O");

            // VirtualPet           = a new type
            // leo                  = identifier
            // new VirtualPet()     = construct a VirtualPet object
            // camelCase
            VirtualPet leoTheCat = new VirtualPet(petName: "leo", petAge: 12, petSpecies: "Cat", petIsAwake: true);
            WriteLine("> Pet 1");
            leoTheCat.Greet(); // Invoke Greet.
            leoTheCat.Eat("some dry food");

            WriteLine("O------>");

            VirtualPet juniorTheParrot = new VirtualPet(petName: "Junior", petAge: 50, petSpecies: "Parrot", petIsAwake: false);
            WriteLine("> Pet 2");
            juniorTheParrot.Greet(); // Invoke Greet.
            leoTheCat.Eat("a worm");
            juniorTheParrot.Sleep();

            WriteLine("O------>");

            VirtualPet callieTheUnicorn = new VirtualPet(petName: "Callie", petAge: 250, petSpecies: "Unicorn", petIsAwake: true);
            callieTheUnicorn.Greet();
            callieTheUnicorn.Eat("rainbows");

            WriteLine("O---------O");
            WriteLine("Press any key to exit...");
            ReadKey();
        }
    }
}
