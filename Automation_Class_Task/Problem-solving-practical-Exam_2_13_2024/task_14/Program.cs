// 14.	Найдите все четырехзначные числа с суммой чисел, равной 15.
// 10. same task but with different solution usign int math operators % and /

const int START_FOUR_DIGIT = 1000;
const int END_FOUR_DIGIT = 9999;
const int FIND_NUM = 15;


List<int> numbersList = new List<int>();
int sumOfDigit = 0;

for (int i = START_FOUR_DIGIT; i < END_FOUR_DIGIT; i++)
{
	string numStr = i.ToString();

	foreach (char digitChar in numStr)
	{
		int digit = digitChar - '0';
		sumOfDigit += digit;
	}

	if (sumOfDigit == FIND_NUM)
	{
        numbersList.Add(i);
    }
}

foreach (int num in numbersList)
{
    Console.Write(num + " ");
}
