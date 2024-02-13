// 15.	Найдите количество четных цифр в заданном натуральном числе.

int naturalNum = 456842;
int count = 0;

Console.WriteLine(naturalNum);
string numStr = naturalNum.ToString();

foreach (char digit in numStr)
{
    int numDigit = digit - '0';
    if (numDigit % 2 == 0)
    {
        count++;
        Console.Write(numDigit);
    }
}


Console.WriteLine();
Console.WriteLine(count);
