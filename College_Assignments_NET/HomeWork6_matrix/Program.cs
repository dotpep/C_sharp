using System;
using System.Data;

namespace HomeWork6_matrix
{
    internal class Program
    {
        static Random rand = new Random();

        static int rows = Convert.ToInt32(Console.ReadLine());
        static int columns = Convert.ToInt32(Console.ReadLine());
        static int[,] matrix = new int[rows, columns];


        static int rows2 = Convert.ToInt32(Console.ReadLine());
        static int columns2 = Convert.ToInt32(Console.ReadLine());
        static int[,] matrix2 = new int[rows2, columns2];


        static void Main(string[] args)
        {
            //Console.Write("Length rows of matrix: ");
            //rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Length columns of matrix: ");
            //columns = Convert.ToInt32(Console.ReadLine());
            // matrix = new int[rows, columns]; // Создаем массив после инициализации rows и columns (тоесть массив должен распологаться сразу после таго как мы будем давать числа для массив) (убрать convert из глобальных переменных)

            Input_Random();
            Input_Random2();

            Output_Random();
            Output_Random2();

            int sum_2x = Sum_Matrix() + Sum_Matrix2();
            Console.WriteLine("sum martix 1: " + Sum_Matrix());
            Console.WriteLine("sum martix 2: " + Sum_Matrix2());
            Console.WriteLine(sum_2x);
        }

        static void Input_Random()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rand.Next(1, 100);

                    //matrix[i, j] = new Random().Next(1, 100);
                }
            }
        }

        static void Input_Random2()
        {
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    matrix2[i, j] = rand.Next(1, 100);

                    //matrix[i, j] = new Random().Next(1, 100);
                }
            }
        }

        static void Output_Random()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Output_Random2()
        {
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int Sum_Matrix()
        {
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) // .GetLength(0) for rows (1) for colums - count length
                {
                    sum += matrix[i, j];
                }
            }

            //Console.WriteLine("Sum of matrix:" + sum);
            return sum;
        }

        static int Sum_Matrix2()
        {
            int sum = 0;

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < columns2; j++) // .GetLength(0) for rows (1) for colums - count length
                {
                    sum += matrix2[i, j];
                }
            }

            //Console.WriteLine("Sum of matrix:" + sum);
            return sum;
        }


    }
}
