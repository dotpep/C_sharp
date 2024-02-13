// 6.	Предоставляется массив актуальных чисел. Размещайте элементы в обратном порядке.

int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };

Array.Reverse(array);

foreach (int item in array)
{
    Console.Write(item + " ");
}


Console.WriteLine();
Console.WriteLine("---");

int length = array.Length; // 6

for (int i = 0; i < length / 2; i++) // 6 / 2 = 3
{
    int temp = array[i]; // 1  // 2
    array[i] = array[length - 1 - i]; // 1 = 6  // 2 = 5
    array[length - 1 - i] = temp; // 6 = 1
    // length - 1 = 2 (0, 1, 2)
}


foreach (int item in array)
{
    Console.Write(item + " ");
}
