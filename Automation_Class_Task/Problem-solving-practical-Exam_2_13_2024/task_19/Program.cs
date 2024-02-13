// 19.	Преобразуйте элементы массива так, чтобы сначала были нулевые элементы,
// а затем располагались остальные.

const int SIZE = 10;
//                          { (0)1, (1)2, (2)0, (3)5, (4)7, (5)2, (6)0, (7)1, (8)1 }
int[] arr = new int[SIZE];

Random rand = new Random();

for (int i = 0; i < SIZE; i++)
{
    arr[i] = rand.Next(0, 5);
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
Console.WriteLine("---");

int zeroIndex = 0;
for (int i = 0; i < SIZE; i++)
{
    if (arr[i] == 0)
    {
        int temp = arr[i]; // arr[3] 5
        arr[i] = arr[zeroIndex]; // 5 == 3
        arr[zeroIndex] = temp; // 3 == 5
        zeroIndex++; // +1 // 3
    }
}

//for (int i = 0; i < SIZE; i++)
//{
//    if (arr[i] == 0)
//    {
//        arr.Prepend(i);
//    }
//}


foreach (int num in arr)
{
    Console.Write(num + " ");
}