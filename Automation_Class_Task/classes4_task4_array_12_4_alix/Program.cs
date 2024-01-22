//1
//using System;

//class Program
//{
//    static void Main()
//    {
//        int n;

//        do
//        {
//            Console.Write("Введите размер массива (натуральное число больше 3): ");
//        } while (!int.TryParse(Console.ReadLine(), out n) || n <= 3);

//        int[] array = GenerateRandomArray(n);

//        Console.WriteLine("Исходный массив:");
//        PrintArray(array);

//        int[] chetnyy = ExtractEvenElements(array);

//        Console.WriteLine("Массив из чётных элементов исходного массива:");
//        PrintArray(chetnyy);
//    }

//    static int[] GenerateRandomArray(int size)
//    {
//        Random random = new Random();
//        int[] array = new int[size];

//        for (int i = 0; i < size; i++)
//        {
//            array[i] = random.Next(0, size + 1);
//        }

//        return array;
//    }

//    static void PrintArray(int[] array)
//    {
//        foreach (var item in array)
//        {
//            Console.Write(item + " ");
//        }
//        Console.WriteLine();
//    }

//    static int[] ExtractEvenElements(int[] array)
//    {
//        int evenCount = 0;
//        foreach (var item in array)
//        {
//            if (item % 2 == 0)
//            {
//                evenCount++;
//            }
//        }

//        int[] chetnyy = new int[evenCount];
//        int index = 0;
//        foreach (var item in array)
//        {
//            if (item % 2 == 0)
//            {
//                chetnyy[index++] = item;
//            }
//        }

//        return chetnyy;
//    }
//}

//2
//using System;

//class Transpose
//{
//    static void Main()
//    {
//        Console.Write("Введите размер квадратной матрицы: ");
//        int size = int.Parse(Console.ReadLine());

//        int[,] matrix = new int[size, size];

//        Random random = new Random();
//        for (int i = 0; i < size; i++)
//        {
//            for (int j = 0; j < size; j++)
//            {
//                matrix[i, j] = random.Next(1, 10); 
//            }
//        }

//        Console.WriteLine("Исходная матрица:");
//        PrintMatrix(matrix);

//        TransposeMatrix(matrix);

//        Console.WriteLine("\nТранспонированная матрица:");
//        PrintMatrix(matrix);
//    }

//    static void TransposeMatrix(int[,] matrix)
//    {
//        int size = matrix.GetLength(0);

//        for (int i = 0; i < size; i++)
//        {
//            for (int j = i + 1; j < size; j++)
//            {
//                // Обмен значений элементов по диагонали
//                int temp = matrix[i, j];
//                matrix[i, j] = matrix[j, i];
//                matrix[j, i] = temp;
//            }
//        }
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        int size = matrix.GetLength(0);

//        for (int i = 0; i < size; i++)
//        {
//            for (int j = 0; j < size; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }
//}


//3
using System;

class Program
{
    static void Main()
    {
        int[] myArray = { 2, 3, 5, 7, 8, 11, 13 };

        int countPrimes = CountPrimes(myArray);

        Console.WriteLine("Количество простых чисел в массиве: " + countPrimes);
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static int CountPrimes(int[] array)
    {
        int count = 0;

        foreach (var item in array)
        {
            if (IsPrime(item))
            {
                count++;
            }
        }

        return count;
    }
}