// 18.	Найдите сумму индексов для наименьшего и наибольшего элементов в массиве.

const int SIZE = 10;
int[] arr = new int[SIZE];

Random rand = new Random();

for (int i = 0; i < SIZE; i++)
{
    arr[i] = rand.Next(1, 20);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();
Console.WriteLine("---");

int max = arr[0];
int min = arr[0];
int maxIndex = 0;
int minIndex = 0;

for (int i = 0; i < SIZE; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        maxIndex = i;
    }
    else if (arr[i] < min)
    {
        min = arr[i];
        minIndex = i;
    }
}

int sum = maxIndex + minIndex;

Console.WriteLine(maxIndex);
Console.WriteLine(minIndex);
Console.WriteLine("---");
Console.WriteLine(sum);
