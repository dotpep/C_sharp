using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes5_pre_exam_15_1
{
    internal class Program
    {
        static int FindOddEven(int number)
        {
            //string IsEven = "number is Even";
            //string IsOdd = "number is Odd";

            int IsEven = 1;
            int IsOdd = -1;

            if (number % 2 == 0)
            {
                return IsEven;
            }
            else
            {
                return IsOdd;
            }
        }

        static void PrintEven(int size_number)
        {
            for (int i = 0; i <= size_number; i += 2)
            {
                Console.Write(i + " ");
            }
        }


        static void CalculateArithmeticOddElement(int[] array)
        {
            int sum = 0;
            int count = 0;
            foreach (int number in array)
            {
                if (number > 10 && number % 2 != 0)  // or number is Odd
                {
                    sum += number;
                    count++;
                }
            }

            // this is a Ternary Operator
            double average = (count > 0) ? sum / count : 0;

            //double average;

            //if (count > 0)
            //{
            //    average = sum / count;
            //}
            //else
            //{
            //    average = 0;
            //}



            Console.WriteLine("Avg of Odd greater than 10 is: " + average);
        }

        static int[] SetRandomNumToArray(int array_size)
        {
            Random random = new Random();
            int[] numbers = new int[array_size];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            return numbers;
        }

    static void Main(string[] args)
        {
            Console.Write("n: ");
            int parsedNum = Convert.ToInt16(Console.ReadLine());
            int ternaryOddOrEven = (parsedNum % 2 == 0) ? 1 : -1;
            Console.WriteLine(ternaryOddOrEven);

            Console.WriteLine("------");

            int n = 39;

            // Even - Четное, Жуп сан
            // Odd - Нечетное, Так сан
            int OddOrEven = FindOddEven(n);
            Console.WriteLine(OddOrEven);


            Console.WriteLine("------");

            const int SIZE_N = 100;
            PrintEven(SIZE_N);

            Console.WriteLine(" ");
            Console.WriteLine("------");


            //int[] array = { 40, 50, 50, 44, 58, 68, 75, 85, 96, 10 };

            const int RANDOM_ARRAY_SIZE = 10;
            int[] randomArray = SetRandomNumToArray(RANDOM_ARRAY_SIZE);

            CalculateArithmeticOddElement(randomArray);
        }
    }
}