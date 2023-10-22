using System;

namespace task4_basics_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Task16()
        {
            Console.Write("amount of students: ");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.Write("amount of chairs: ");
            int chairs = Convert.ToInt32(Console.ReadLine());

            if (students > chairs)
            {
                Console.WriteLine("not enough " + (students - chairs) + " chairs.");
            }
            else if (chairs > students)
            {
                Console.WriteLine("extra chairs: " + (chairs - students));
            }
            else
            {
                Console.WriteLine("same amount of students and chairs");
            }
        }


        static void Task23()
        {
            Console.Write("positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int last_digit = num % 10; // 435 = 5
            int rounded_num;

            if (last_digit >= 5)
            {
                rounded_num = num + (10 - last_digit); // 109 + 10 - 9
            }
            else
            {
                rounded_num = num - last_digit;
            }

            Console.WriteLine("nearest round num: " + rounded_num);
        }



        static void Task30()
        {
            Console.Write("number of apartment (positive 0-2): ");
            int flat_number = Convert.ToInt32(Console.ReadLine());

            if (flat_number < 1)
            {
                Console.WriteLine("apartment number must be positive");
                return;
            }

            int floor = (flat_number - 1) / 3 + 1;
            int position = (flat_number - 1) % 3;

            Console.WriteLine("apartment located on " + floor + " floor.");

            switch (position)
            {
                case 0:
                    Console.WriteLine("on left");
                    break;
                case 1:
                    Console.WriteLine("in center");
                    break;
                case 2:
                    Console.WriteLine("on right");
                    break;
            }
        }

        static void Task37()
        {
            Console.Write("integer (hour 24): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour >= 0 && hour < 24)
            {
                if (hour >= 6 && hour < 10)
                {
                    Console.WriteLine("morning");
                }
                else if (hour >= 10 && hour <= 18)
                {
                    Console.WriteLine("afternoon");
                }
                else if (hour > 18 && hour <= 22)
                {
                    Console.WriteLine("evening");
                }
                else
                {
                    Console.WriteLine("night");
                }
            }
            else
            {
                Console.WriteLine("your input is not in area of 24 hours.");
            }
        }


        static void Task44()
        {
            Console.Write("positive 3 digit: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 100 && num <= 999)
            {
                int digit1 = num / 100;
                int digit2 = (num / 10) % 10;
                int digit3 = num % 10;

                if (digit1 == digit2 && digit2 == digit3) // and
                {
                    Console.WriteLine("all (3) numbers a same");
                }
                else if (digit1 == digit2 || digit2 == digit3 || digit1 == digit3) // or (3 == 3 == 2 = true (2x) = true) 
                {
                    Console.WriteLine("2 numbers a same");
                }
                else
                {
                    Console.WriteLine("there is not any same numbers");
                }
            }
            else
            {
                Console.WriteLine("not 3 digit");
            }
        }


    }
}
