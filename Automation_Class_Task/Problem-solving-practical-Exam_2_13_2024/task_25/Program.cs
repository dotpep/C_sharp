// 25.	Напишите программу, которая печатает все четырехзначные цифры,
// не содержащие двух одинаковых цифр в случайно заполненных элементах массива.

const int START_FOUR_DIGIT = 1000;
const int END_FOUR_DIGIT = 9999;

int[] array = GenerateRandomArray(START_FOUR_DIGIT, END_FOUR_DIGIT);

foreach (int num in array)
{
    if (HasUniqueDigits(num))
    {
        Console.Write(num + " ");
    }
}


static int[] GenerateRandomArray(int minValue, int maxValue)
{
    Random random = new Random();
    int[] array = new int[100]; // Создаем массив из 100 элементов

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // Заполняем массив случайными четырехзначными числами
    }

    return array;
}

static bool HasUniqueDigits(int number)
{
    int[] digits = new int[10]; // подсчет количества каждой цифры

    while (number > 0)
    {
        int digit = number % 10;
        if (digits[digit] > 0) // digit is not unique because already added in array digits
        {
            return false;
        }
        digits[digit]++;
        number /= 10;
    }

    return true; // if all digit is unique
}