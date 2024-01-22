using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int Task7(int[] array)
    {
        // SumOfAbsoluteValuesAfterFirstNegative
        int firstNegativeIndex = -1;
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                firstNegativeIndex = i;
                break;
            }
        }

        if (firstNegativeIndex != -1)
        {
            for (int i = firstNegativeIndex + 1; i < array.Length; i++)
            {
                sum = sum + Math.Abs(array[i]);
            }
        }

        return sum;
    }

    static void Task8(int[] array)
    {
        // RemoveNegativeNumbers
        int nonNegativeCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= 0)
            {
                array[nonNegativeCount] = array[i];
                nonNegativeCount++;
            }
        }

        int[] newArray = new int[nonNegativeCount];
        Array.Copy(array, newArray, nonNegativeCount);

        array = newArray;
    }

    static void Task9(int[] array, int startInterval, int endInterval)
    {
        // CompressArrayByInterval
        int validCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < startInterval || array[i] > endInterval)
            {
                array[validCount] = array[i];
                validCount++;
            }
        }

        int[] newArray = new int[validCount];
        Array.Copy(array, newArray, validCount);

        array = newArray;
    }

    static void Task10(int[] array, out int[] positiveNumbers, out int[] negativeNumbers)
    {
        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                positiveCount++;
            }
            else if (array[i] < 0)
            {
                negativeCount++;
            }
        }

        positiveNumbers = new int[positiveCount];
        negativeNumbers = new int[negativeCount];

        int positiveIndex = 0;
        int negativeIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                positiveNumbers[positiveIndex] = array[i];
                positiveIndex++;
            }
            else if (array[i] < 0)
            {
                negativeNumbers[negativeIndex] = array[i];
                negativeIndex++;
            }
        }
    }


    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }
    }

    static void Main()
    {
        // 9 Декабря: Задания Массивы 2 Группа (сдача 18.12.2023)
        int[] array = { 3, -5, 2, 8, -1, 7, -6, 4 };
        int startInterval = 3;
        int endInterval = 7;

        // 7) Сумма модулей элементов массива, расположенных после первого отрицательного
        int sum = Task7(array);
        Console.WriteLine("---Task 7--- \nsum of array after first negative number: " + sum);

        // 8) Удаление отрицательных элементов массива
        Task8(array);
        Console.WriteLine("\n---Task 8--- \ndelete negative elements in array: ");
        PrintArray(array);

        // 9) Сжать массив, удалив элементы, принадлежащие интервалу
        Task9(array, startInterval, endInterval);
        Console.WriteLine($"\n\n---Task 9--- \ninterval: [{startInterval}, {endInterval}]: ");
        PrintArray(array);

        // 10) Разложить положительные и отрицательные числа по разным массивам
        int[] positiveNumbers;
        int[] negativeNumbers;
        Task10(array, out positiveNumbers, out negativeNumbers);
        Console.WriteLine("\n\n---Task 10---");
        Console.WriteLine("Positive numbers: ");
        PrintArray(positiveNumbers);
        Console.WriteLine("Negative numbers: ");
        PrintArray(negativeNumbers);
        Console.WriteLine("\n\n---end---\n");
    }