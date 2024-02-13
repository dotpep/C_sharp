// 20.	Найдите наименьший четный элемент в массиве. Если нет, отпустите первый элемент.

const int SIZE = 5;
int[] arr = new int[SIZE] { 54, 3, 3, 5, 7 };


int minEven = arr[0];

for (int i = 0; i < SIZE; i++)
{
    if (arr[i] % 2 == 0 && arr[i] < minEven)
    {
        minEven = arr[i];
    }
}

if (minEven != arr[0])
{
    Console.WriteLine(minEven);
}
else
{
    Console.WriteLine(arr[0]);
}

//Console.WriteLine(arr.Min());
