using System;

namespace n58_encapsulation_opp
{
    // Encapsulation (work with mixing private and public access modifiers for clear oop code) default without modi is private

    internal class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun(isLoaded: false); // Gun() - constructor

            //gun.isLoaded = true; // 1
            //gun.Shoot();
            gun.Shoot();
        }
    }


    class Gun
    {
        public Gun(bool isLoaded) // 4
        {
            //isLoaded = true; // 2
            //Reload(); // 3
            //this.isLoaded = isLoaded; // 4 define
            _isLoaded = isLoaded; // 4 _isLoaded this.
        }


        //public bool isLoaded;
        private bool _isLoaded; // in private _namevariable

        private void Reload()
        {
            Console.WriteLine("Reload...");

            _isLoaded = true;

            Console.WriteLine("Loaded!");
        }

        public void Shoot()
        {
            if (!_isLoaded) // if not isLoaded false
            {
                Console.WriteLine("Weapons don't loaded!");
                Reload();
            }
            Console.WriteLine("Trrr - Trrr\n"); // true
            _isLoaded = false;
        }


    }
}