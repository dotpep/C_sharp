using System;

namespace task2_basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task16();
        }

        static void Task16()
        {
            Console.Write("input 4 symbols num (for reverse): ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (num >= 1000 && num <= 9999)
            {
                int reversed = 0;
                while (num > 0)
                {
                    int digit = num % 10; // calculate last digit (123 % 10 = 3)
                    reversed = reversed * 10 + digit; // shift digits to left side and add last digit (shift 1 digit)
                    num /= 10; // delete last digit (123 / 10 = 12)
                }

                Console.WriteLine($"reversed num: {reversed}");

            }
            else
            {
                Console.WriteLine("your input not consists 4 symbols or doesnt integer.");
            }


            /* 
            Назовем «перестановкой» операцию над числом, 
            при которой его первая и последняя цифры меняются местами. 
            Например, из числа 1234 получается число 4231. 
            Напишите программу, которая принимает с клавиатуры трехзначное число и строит из него новое число методом
            «перестановки».
             */

        }

        static void Task23()
        {
            Console.Write("input 4 symbols num (shift right in circle): ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1000 && num <= 9999)
            {
                int last_digit = num % 10;
                int first_three_digit = num / 10;
                int shifted = last_digit * 1000 + first_three_digit; // 1000 is for shift 3 digit

                Console.WriteLine($"shift right in circle num: {shifted}");

            }
            else
            {
                Console.WriteLine("your input not consists 4 symbols or doesnt integer.");
            }

            /* 
             Напишите класс, который выполняет «сдвиг вправо по кругу» для четырехзначного числа.
             */
        }
    }
}
