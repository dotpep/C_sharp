using System;

namespace n71_inheritance_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person { FirstName = "Kay", LastName = "Altos" }; // 1
            //person.PrintName();

            //Student student = new Student { FirstName = "Adam", LastName = "Pandor" }; // 2
            //student.PrintName();
            //student.Learn(); // 3

            //Person person = new Student { FirstName = "Adam", LastName = "Pandor" }; // 4
            //person.PrintName();
            //person.learn(); // errors

            //Person person = new Person { FirstName = "Kay", LastName = "Altos" }; // 5
            //PrintFullName(person);

            Student student = new Student { FirstName = "Adam", LastName = "Pandor" };
            student.Learn();

            PrintFullName(student);
        }

        static void PrintFullName(Person person) // 5
        {
            Console.WriteLine($"Family: {person.LastName}\t Name: {person.FirstName}");
        }

    }


    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"My name is {FirstName}");
        }


    }



    class Student : Person
    {
        public void Learn() // 3 
        {
            Console.WriteLine("I am Studying!");
        }
    }

}
