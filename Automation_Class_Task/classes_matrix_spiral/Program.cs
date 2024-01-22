using System;

public class Program
{
    public static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        PrintSpiralOrder(matrix);
    }

    public static void PrintSpiralOrder(int[,] matrix)
    {
        int top = 0;
        int bottom = matrix.GetLength(0) - 1;
        int left = 0;
        int right = matrix.GetLength(1) - 1;

        while (top <= bottom && left <= right)
        {
            for (int i = left; i <= right; i++)
            {
                Console.Write(matrix[top, i] + " ");
            }
            Console.WriteLine();
            top++;

            for (int i = top; i <= bottom; i++)
            {
                Console.Write(matrix[i, right] + " ");
            }
            Console.WriteLine();
            right--;

            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    Console.Write(matrix[bottom, i] + " ");
                }
                bottom--;
            }

            Console.WriteLine();

            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    Console.Write(matrix[i, left] + " ");
                }
                left++;
            }
        }

        Console.WriteLine();
    }
}
