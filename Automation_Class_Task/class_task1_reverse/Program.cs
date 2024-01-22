using System;
using System.Security.Cryptography;

namespace class_task1_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task3();
        }


        static void Task1()
        {
            //Console.Write("num: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            int num = 123;


            int first_digit = num / 100;
            int middle_digit = (num / 10) % 10;
            int last_digit = num % 10;


            Console.WriteLine(last_digit + "" + middle_digit + "" + first_digit);
        }

        static void Task2()
        {
            Console.Write("num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //int num = 12345678;

            int reversed = 0;
            while (num > 0)
            {
                int digit = num % 10;
                reversed = (reversed * 10) + digit;
                num = num / 10;
            }

            Console.WriteLine($"reversed: {reversed}");


            //int first_digit = num / 10000;
            //int second_digit = (num / 1000) % 10;
            //int third_digit = (num / 100) % 10;
            //int middle_digit = (num / 10) % 10;
            //int last_digit = num % 10;

            //Console.WriteLine("first_digit: " + first_digit);
            //Console.WriteLine("second_digit: " + second_digit);
            //Console.WriteLine("third_digit: " + third_digit);
            //Console.WriteLine("middle_digit: " + middle_digit);
            //Console.WriteLine("last_digit: " + last_digit);
        }

        static void Task3()
        {
            Console.Write("your name:");
            string name = Console.ReadLine();
            Console.Write("your surname:");
            string surname = Console.ReadLine();

            //Console.WriteLine($"surname: {surname} name: {name}");

            Console.WriteLine(surname + " " + name);
            Console.WriteLine(name + surname);

            if (name == surname)
            {
                Console.WriteLine("Error Same");
            }
        }

        static void Task4()
        {
            Console.Write("1. your name:");
            string name_1 = Console.ReadLine();
            Console.Write("1. your surname:");
            string surname_1 = Console.ReadLine();

            Console.Write("2. your name:");
            string name_2 = Console.ReadLine();
            Console.Write("1. your surname:");
            string surname_2 = Console.ReadLine();


            if (name_1 == name_2 && surname_1 == surname_2)
            {
                Console.WriteLine("тезки и однофамильцы");
            }
            else if (name_1 == name_2 && surname_1 != surname_2)
            {
                Console.WriteLine("тезки и не однофамильцы");
            }
            else if (name_1 != name_2 && surname_1 == surname_2)
            {
                Console.WriteLine("не тезки и однофамильцы");
            }
            else
            {
                Console.WriteLine("не тезки и не однофамильцы");
            }
        }

    }
}
