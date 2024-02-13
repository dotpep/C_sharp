// 17.	Даются случайные натуральные числа от 35 до 87.
// Выведите в консоль числа, из которых остается 1, 2 или 5 остатков, если разделить их на 7.

const int START = 35;
const int END = 87;

Random rand = new Random();

const int LENGTH = END - START - 1;
int[] arr = new int[LENGTH];


for (int i = 0; i < LENGTH; i++)
{
    arr[i] = rand.Next(START, END);
    Console.Write(arr[i] + " ");
}

Console.WriteLine();
Console.WriteLine("---");

foreach (var item in arr)
{
    if (
    item % 7 == 1 ||
    item % 7 == 2 ||
    item % 7 == 5
    )
    {
        Console.Write(item + " ");
    }
}

//int naturalNum = rand.Next(START, END);

//if (
//    naturalNum % 7 == 1 || 
//    naturalNum % 7 == 2 || 
//    naturalNum % 7 == 5
//    )
//{
//    Console.WriteLine(naturalNum);
//}
