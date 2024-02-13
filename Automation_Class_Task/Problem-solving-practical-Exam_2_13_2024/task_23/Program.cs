// 23.	В поле Информация напишите программу,
// исключающую из массива элементы с отрицательными номерами.

//const int SIZE = 7;
//int[] arr = new int[SIZE] { 2, 4, 9, -2, 5, -9, 10 };

int[] arr = { 2, 4, 9, -2, 5, -9, 10 };


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        int numIdx = Array.IndexOf(arr, arr[i]);
        List<int> tmp = new List<int>(arr);
        tmp.RemoveAt(numIdx);
        arr = tmp.ToArray();
    }
}


foreach (int num in arr)
{
    Console.Write(num + " ");
}
