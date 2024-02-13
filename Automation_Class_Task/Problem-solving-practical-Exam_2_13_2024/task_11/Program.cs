// 11.	Предоставляется массив из 30 конкретных чисел.
// Найдите индекс элемента, имеющего наибольшее значение в массиве.

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
