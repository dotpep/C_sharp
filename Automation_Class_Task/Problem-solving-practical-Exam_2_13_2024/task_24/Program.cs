// 24.	Напишите программу, которая вычисляет и печатает количество различных букв в заданном тексте.

Console.Write("Any text to count letters: ");
string text = Console.ReadLine();


Dictionary<char, int> countDict = new Dictionary<char, int>();

foreach (char letter in text)
{
	if (char.IsLetter(letter))
	{
        if (countDict.ContainsKey(letter))
        {
            countDict[letter]++;
        }
        else
        {
            countDict[letter] = 1;
        }
    }
}

Console.WriteLine("Count difference letters in text:");
foreach (var kvp in countDict)
{
    Console.WriteLine($"Letter '{kvp.Key}' occurs {kvp.Value} times");
}

//foreach (char letter in text)
//{
//    Console.Write(letter + " ");
//}
