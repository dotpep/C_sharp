// 12.	Найдите сумму индексов для наименьшего и наибольшего элементов в массиве.

const int SIZE = 10;
int[] arr = new int[SIZE];

Random random = new Random();
for (int i = 0; i < SIZE; i++)
{
    arr[i] = random.Next(0, 100);
}


foreach (int item in arr)
{
    Console.Write(item + " ");
}


Console.WriteLine();
Console.WriteLine("---");
Console.WriteLine("Maximum:");


// Maximum
int max = arr.Max();
int maxIndex = 0;

for (int i = 0; i < SIZE; i++)
{
    if (arr[i] == max)
    {
        maxIndex = i;
    }
}

Console.WriteLine("Maximum value in array: " + max);
Console.WriteLine("Index of maximum value in array: " + maxIndex);



Console.WriteLine();
Console.WriteLine("---");
Console.WriteLine("Minimum:");


// Minimum
int min = arr.Min();
int minIndex = 0;

for (int i = 0; i < SIZE; i++)
{
    if (arr[i] == min)
    {
        minIndex = i;
    }
}

Console.WriteLine("Minimum value in array: " + min);
Console.WriteLine("Index of minimum value in array: " + minIndex);
