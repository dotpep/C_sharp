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

        // new array with copy
        int[] newArray = new int[nonNegativeCount];
        Array.Copy(array, newArray, nonNegativeCount);

        // rewrite array
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

        // new array with copy
        int[] newArray = new int[validCount];
        Array.Copy(array, newArray, validCount);

        // rewrite array
        array = newArray;
    }

    static void Task10(int[] array, out int[] positiveNumbers, out int[] negativeNumbers)
    {
        // SplitPositiveAndNegativeNumbers
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


    static void TaskMain()
    {
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


    static void Main()
    {
        TaskMain();
    }

    static void SubMain()
    {
        int[] array = { 3, -5, 2, 8, -1, 7, -6, 4 };
        int startInterval = 3;
        int endInterval = 7;

        // 7) Сумма модулей элементов массива, расположенных после первого отрицательного
        int sum = SumOfAbsoluteValuesAfterFirstNegative(array);
        Console.WriteLine("Task 7 sum of array after first negative number: " + sum);

        // 8) Удаление отрицательных элементов массива
        int[] arrayWithoutNegatives = RemoveNegativeNumbers(array);
        Console.WriteLine("Task 8 delete negative elements in array: " + string.Join(", ", arrayWithoutNegatives));

        // 9) Сжать массив, удалив элементы, принадлежащие интервалу
        int[] compressedArray = CompressArrayByInterval(array, startInterval, endInterval);
        Console.WriteLine("Task 9 interval: [" + startInterval + ", " + endInterval + "]: " + string.Join(", ", compressedArray));

        // 10) Разложить положительные и отрицательные числа по разным массивам
        List<int> positiveNumbers;
        List<int> negativeNumbers;
        SplitPositiveAndNegativeNumbers(array, out positiveNumbers, out negativeNumbers);
        Console.WriteLine("Task 10 Positive numbers: " + string.Join(", ", positiveNumbers));
        Console.WriteLine("\tОтрицательные числа: " + string.Join(", ", negativeNumbers));
    }

    static int SumOfAbsoluteValuesAfterFirstNegative(int[] array)
    {

        int firstNegativeIndex = Array.FindIndex(array, x => x < 0);

        if (firstNegativeIndex != -1)
        {
            return array.Skip(firstNegativeIndex + 1).Sum(Math.Abs);
        }
        else
        {
            return 0;
        }
    }

    static int[] RemoveNegativeNumbers(int[] array)
    {
        return array.Where(x => x >= 0).ToArray();
    }

    static int[] CompressArrayByInterval(int[] array, int startInterval, int endInterval)
    {
        return array.Where(x => x < startInterval || x > endInterval).ToArray();
    }

    static void SplitPositiveAndNegativeNumbers(int[] array, out List<int> positiveNumbers, out List<int> negativeNumbers)
    {
        positiveNumbers = new List<int>();
        negativeNumbers = new List<int>();

        foreach (int number in array)
        {
            if (number > 0)
                positiveNumbers.Add(number);
            else if (number < 0)
                negativeNumbers.Add(number);
        }
    }
}
