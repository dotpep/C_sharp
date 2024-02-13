// 9.	Отбрасывайте элементы, которые встречаются более чем в два раза чаще 
// в заданном массиве целых чисел.

// similiar to task 22

//int[] arr = { 1, 2, 3, 2, 3, 2, 4, 4, 5, 4, 5, 6, 4, 6 };
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


int[] array = { 1, 2, 2, 3, 4, 4, 5, 5, 6, 6, 7, 8, 8, 8, 9, 9, 9, 9 };

Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

foreach (int num in array)
{
	if (frequencyMap.ContainsKey(num))
	{
		frequencyMap[num]++;
	}
	else
	{
        frequencyMap[num] = 1;
    }
}

List<int> result = new List<int>();

foreach (var kvalue in frequencyMap)
{
	if (kvalue.Value <= 2)
	{
		result.Add(kvalue.Key);
	}
}

//foreach (int num in arr)
//{
//    if (countDict[num] <= 2)
//    {
//        filteredList.Add(num);
//    }
//}



Console.WriteLine("Filtered:");
foreach (int num in result)
{
    Console.Write(num + " ");
}

