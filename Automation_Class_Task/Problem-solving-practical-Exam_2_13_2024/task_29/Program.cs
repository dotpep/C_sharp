// 29.	Текстовое поле содержит случайное натуральное число меньше 100.
// Найдите в арифметическом окружении цифры этого числа.

Console.Write("num 1 ... 99:");
string input = Console.ReadLine();

if (IsValide(input))
{
    Console.WriteLine("Digits:");
    foreach (char digit in input)
    {
        Console.WriteLine(digit);
    }
}
else
{
    Console.WriteLine("Error out of range 100");
}

static bool IsValide(string input)
{

    return int.TryParse(input, out int number) && ValidateRange(number);
}

static bool ValidateRange(int number)
{
    return number >= 0 && number <= 100;
}
