// 22.	Отбрасывают все числа, которые повторяются в массиве более двух раз.

// similiar to task 9


int[] arr = { 1, 2, 3, 2, 3, 2, 4, 4, 5, 4, 5, 6, 4, 6 };
// 1, 3, 5, 6

/*
 * 2 occur = 3 times
 * 3 occur = 2 times
 * 4 occur = 4 times
 * 5 occur = 2 times
 * 6 occur = 2 times
 * 1 occur = 1 times
 * 
 * 2 and 4 occur more than twice as often as the other element
*/


Dictionary<int, int> countDict = new Dictionary<int, int>();

// подсчитаем количество вхождений для каждого элемента
foreach (int num in arr)
{
    if (countDict.ContainsKey(num))
    {
        countDict[num]++;
    }
    else
    {
        countDict[num] = 1;
    }
}


List<int> filteredList = new List<int>();

// добавляем элементы, которые встречаются не более чем два раза
foreach (int num in arr)
{
    if (countDict[num] <= 2)
    {
        filteredList.Add(num);
    }
}


Console.WriteLine("filtered result: ");

foreach (int num in filteredList)
{
    Console.Write(num + " ");
}


Console.WriteLine();
Console.WriteLine("unique result: ");

List<int> unique = filteredList.Distinct().ToList();

foreach (int num in unique)
{
    Console.Write(num + " ");
}
