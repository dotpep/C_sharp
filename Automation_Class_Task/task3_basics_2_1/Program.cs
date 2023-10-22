using System;

namespace task3_basics_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task23();
        }

        static void Task16()
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


        static void Task23()
        {
            Console.Write("possitive 3 digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 100 && num <= 999)
            {
                int digit1 = num / 100;
                int digit2 = (num / 10) % 10;
                int digit3 = num % 10;

                int sum = digit1 + digit2 + digit3;
                int mult_sum = digit1 * digit2 * digit3;

                Console.WriteLine(sum);
                Console.WriteLine(mult_sum);
                Console.WriteLine(sum % 2);
                Console.WriteLine(mult_sum % 2);

                if (sum % 2 == 0 && mult_sum % 2 == 0)
                {
                    Console.WriteLine("дважды четное");
                }
                else
                {
                    Console.WriteLine("не дважды четное");
                }
            }
            else
            {
                Console.WriteLine("not 3 digit");
            }
        }



        static void Task30()
        {
            Console.Write("possitive 3 digit number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 100 && num <= 999)
            {
                int digit1 = num / 100;
                int digit2 = (num / 10) % 10;
                int digit3 = num % 10;

                Console.WriteLine(num % digit1);
                Console.WriteLine(num % digit2);
                Console.WriteLine(num % digit3);

                // without equal 0 and 123 % 123 == 0
                
                if (digit1 != 0 && num % digit1 == 0) 
                {
                    Console.WriteLine("num divisible by: " + digit1);
                }
                if (digit2 != 0 && num % digit2 == 0) 
                {
                    Console.WriteLine("num divisible by: " + digit2);
                }
                if (digit3 != 0 && num % digit3 == 0) 
                {
                    Console.WriteLine("num divisible by: " + digit3);
                }


            }
            else
            {
                Console.WriteLine("not 3 digit");
            }
        }


        static void Task37()
        {
            Console.Write("1. firstname");
            string firstname_1 = Console.ReadLine();
            Console.Write("1. lastname");
            string lastname_1 = Console.ReadLine();

            Console.Write("2. firstname");
            string firstname_2 = Console.ReadLine();
            Console.Write("2. lastname");
            string lastname_2 = Console.ReadLine();

            if (firstname_1 == firstname_2 && lastname_1 == lastname_2)
            {
                Console.WriteLine("1 and 2 both have same firstname and lastname");
            }
            else if (firstname_1 == firstname_2)
            {
                Console.WriteLine("1 and 2 both have same firstname");
            }
            else if (lastname_1 == lastname_2)
            {
                Console.WriteLine("1 and 2 both have same lastname");
            }
            else
            {
                Console.WriteLine("1 and 2 both not have any similiarity in firstname and lastname");
            }


        }


    }
}
