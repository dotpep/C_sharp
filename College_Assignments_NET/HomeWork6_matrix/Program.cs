using System;

namespace HomeWork6_matrix
{
    internal class Program
    {
        static Random rand = new Random();

        static int rows = Convert.ToInt32(Console.ReadLine());
        static int columns = Convert.ToInt32(Console.ReadLine());
        static int[,] matrix = new int[rows, columns];


        static void Main(string[] args)
        {
            Input_Random();
            Output_Random();

            Console.WriteLine(" ");

            Input_Random();
            Output_Random();

            Console.WriteLine("sum of 2 matrix: " + Sum_Matrix());
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

            // 2
            int sum2 = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) // .GetLength(0) for rows (1) for colums - count length
                {
                    sum += matrix[i, j];
                }
            }

            //Console.WriteLine("Sum of matrix:" + sum);
            return sum + sum2;

        }
    }
}
