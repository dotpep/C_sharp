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


        static void Main(string[] args)
        {
            //Console.Write("Length rows of matrix: ");
            //rows = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Length columns of matrix: ");
            //columns = Convert.ToInt32(Console.ReadLine());
            // matrix = new int[rows, columns]; // Создаем массив после инициализации rows и columns (тоесть массив должен распологаться сразу после таго как мы будем давать числа для массив) (убрать convert из глобальных переменных)

            Input_Random();


            Output_Random();
            //Sum_Matrix();
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

        static void Sum_Matrix()
        {
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) // .GetLength(0) for rows (1) for colums - count length
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine("Sum of matrix:" + sum);
        }


    }
}
