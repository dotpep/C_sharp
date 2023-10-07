using System;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Laptop laptop = new Laptop("Asus Tuf", "Intel i7", 1000, 15, 70);
            laptop.Info();
            laptop.Sum();
            
            Laptop laptop_2 = new Laptop("Apple iMac", "Intel i5", 1700, 10, 40);
            laptop_2.Info();
            laptop_2.Sum();
        }
    }
}
