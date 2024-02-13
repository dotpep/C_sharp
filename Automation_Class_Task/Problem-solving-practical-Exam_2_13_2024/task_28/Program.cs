// 28.	Напишите программу для нахождения наибольшей суммы последовательных элементов,
// введенных с 10 случайными числами в целом.


static void Main()
{
    int[] array = GenerateRandomArray(10, -100, 100);

    Console.WriteLine("Random array: ");
    PrintArray(array);

    int maxSum = FindMaxSubarraySum(array);
    Console.WriteLine(maxSum);
}

Main();



static int FindMaxSubarraySum(int[] array)
{
    int maxSum = int.MinValue;
    int currentSum = 0;

    foreach (int num in array)
    {
        currentSum = Math.Max(num, currentSum + num); // Находим максимальную сумму до текущего элемента
        maxSum = Math.Max(maxSum, currentSum); // Обновляем максимальную сумму
    }

    return maxSum;
}


static int[] GenerateRandomArray(int size, int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

static void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

