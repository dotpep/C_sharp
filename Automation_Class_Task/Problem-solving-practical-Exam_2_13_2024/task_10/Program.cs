// 10.	Найдите все четырехзначные числа с суммой чисел, равной 15

// (four digit number) четырехзначное число: 1000 ... 9999


const int FOUR_DIGIT_START = 1000;
const int FOUR_DIGIT_END = 9999;

const int FIND_NUM = 15;

List<int> numbersList = new List<int>();

//int first = 0;
//int second = 0;
//int third = 0;
//int fourth = 0;

for (int num = FOUR_DIGIT_START; num <= FOUR_DIGIT_END; num++)
{
    int firstDigit = num / 1000;
    int secondDigit = (num / 100) % 10;
    int thirdDigit = (num / 10) % 10;
    int fourthDigit = num % 10;

    int sumOfDigit = firstDigit + secondDigit + thirdDigit + fourthDigit;

    if (sumOfDigit == FIND_NUM)
	{
        numbersList.Add(num);
    }
}


foreach (int num in numbersList)
{
    Console.Write(num + " ");
}


//int number = 2595;

//int first = number / 1000; // 2
//int second = (number / 100) % 10; // 5
//int third = (number / 10) % 10; // 9
//int fourth = number % 10; // 5

//Console.WriteLine($"{first}, {second}, {third}, {fourth}");

