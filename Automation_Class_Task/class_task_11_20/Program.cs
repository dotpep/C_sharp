using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_11_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_25();
        }

        static void Task_8()
        {
            // написать программу поиска произведения последовательности чисел,
            // вводимых с клавиатуры, предшествующих первому введеному отрицательному числу:
            // пример: 1, 2, 3, 4, 5, -2.

            List<int> numbers = new List<int>();
            int multiply = 1;

            Console.WriteLine("number multiply (stop neg num): ");

            while (true)
            {
                string input = Console.ReadLine();
                int number = Convert.ToInt32(input);

                if (number < 0)
                    break;

                numbers.Add(number);
                multiply *= number;
            }

            Console.WriteLine("numbers multiply: " + multiply);

        }

        static void Task_11()
        {
            // найти сумму квадратов нечетных чисел в интервале,
            // заданном значениями переменных: m и n.

            Console.WriteLine("number m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number n:");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0) 
                {
                    sum += i * i;
                }
            }

            Console.WriteLine("сумма: " + m + " до " + n + " равна " + sum);
        }


        static void Task_16()
        {
            // дано число n 1 до 1000 и число m.
            // Вывести результат квадрат целочисленного деление n на m.

            Console.WriteLine("от 1 до 1000: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("number m:");
            int m = Convert.ToInt32(Console.ReadLine());

            int result = (n / m) * (n / m);

            Console.WriteLine("reult of square - n ^ m: " + result);
        }


        static void Task_25()
        {
            // Составьте программу,
            // вычисляющию разность квадратов всех чисел от 1 до N.


            Console.WriteLine("1 to iterate N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            //int difference = 0;

            for (int i = 1; i <= N; i++)
            {
                //difference = difference - i * i;
                Console.WriteLine($"{i} ^ 2 - {i+1} ^ 2 = ({i} + {i + 1})({i} - {i + 1})");
            }

            //Console.WriteLine("iterate 1 to " + N + " equal " + difference);

        }




        static void Task8_test1()
        {

            List<int> numbers = new List<int>();
            int multiply = 1;

            Console.WriteLine("number multiply (stop neg num): ");

            while (true)
            {
                string input = Console.ReadLine();
                int number;

                if (int.TryParse(input, out number))
                {
                    if (number < 0)
                        break;

                    numbers.Add(number);
                    multiply *= number;
                }
                else
                {
                    Console.WriteLine("Error input number.");
                }
            }

            Console.WriteLine("numbers multiply: " + multiply);
        }
    }
}