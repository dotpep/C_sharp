using System;

namespace task1_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // void Task16() // without using static
            //Program program = new Program();
            //program.Task16();

            Task37();
        }

        static void Task16()
        {
            Console.Write("integer: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num + 6);
            Console.WriteLine(num - 12);
        }

        static void Task23()
        {
            Console.Write("first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"squaring, num1: {num1 * num1} num2: {num2 * num2}");
            Console.WriteLine($"squaring, sum of num1 and num2: {(num1 * num1) + (num2 * num2)}");
        }


        static void Task30()
        {
            Console.Write("hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("minutes: ");
            int minutes = Convert.ToInt32(Console.ReadLine());

            int total_minutes = hours * 60 + minutes;
            int total_second = total_minutes * 60;
            int minutes_until_midnight = 24 * 60 - total_minutes;

            Console.WriteLine("total_second: " + total_second);
            Console.WriteLine("total_minutes: " + total_minutes);
            Console.WriteLine("minutes_until_midnight: " + minutes_until_midnight);
        }

        static void Task37()
        {
            Console.Write("your name: ");
            string name = Console.ReadLine();
            Console.Write("your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"surname: {surname} name: {name}");
            Console.WriteLine($"name: {name} surname: {surname}");

        }

    }
}
