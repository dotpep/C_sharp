// 30.	Дан массив из 10 случайных целых чисел.
// Вычислить арифметическое окружение нечетных элементов больше 10 в массиве.

int[] numbers = new int[10];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 100);
}

// Вычисляем сумму нечетных элементов, больших 10
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 10 && numbers[i] % 2 != 0)
    {
        sum += numbers[i];
    }
}

Console.WriteLine($"Sum: {sum}");
