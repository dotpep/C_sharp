// 3.	Удалите все повторяющиеся элементы из одномерного массива,
// а затем напишите программу так, чтобы каждое значение встречалось в массиве только один раз.
int[] arr = { 2, 2, 1, 4, 4, 3, 5 };

int[] new_arr = arr.Distinct().ToArray();

foreach (int item in new_arr)
{
    Console.Write(item + " ");
}

//Array.Sort(new_arr);
//Array.ForEach(new_arr, Console.WriteLine);

//string arrayAsString = string.Join(" ", new_arr);
//Console.WriteLine(arrayAsString);

Console.WriteLine(" ");



HashSet<int> uniqueSequence = new HashSet<int>();

// Fill our hashset
foreach (int num in arr)
{
    uniqueSequence.Add(num);
}

// Convert hashset to array
//int[] size_arr = new int[5];
int[] new_arr2 = new int[uniqueSequence.Count];
uniqueSequence.CopyTo(new_arr2);


foreach (int num in new_arr2)
{
    Console.Write(num + " ");
}


Console.WriteLine(" ");
// or just 

foreach (int num in uniqueSequence)
{
    Console.Write(num + " ");
}
