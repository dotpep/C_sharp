// 21.	Найдите сумму элементов массива между первыми двумя нулями.
// Если массив не содержит двух нулей, выведите ноль.

// same as 13 task

const int SIZE = 10;     // 0, 1, 2!, 3, 4, 5, 6! 7, 8, 9!
int[] arr = new int[SIZE] { 1, 2, 0, 5, 7, 2, 0, 1, 1, 0 };

const int FIND_N = 0;

int firstZeroIndex = -1;
int secondZeroIndex = -1;


for (int i = 0; i < SIZE; i++)
{
    if (arr[i] == FIND_N)
    {
        if (firstZeroIndex == -1)
        {
            firstZeroIndex = i;
        }
        else if (secondZeroIndex == -1)
        {
            secondZeroIndex = i;
            break;
        }
    }
}


int sum = 0;

if (firstZeroIndex != -1 && secondZeroIndex != -1)
{
    for (int i = firstZeroIndex + 1; i < secondZeroIndex; i++)
    {
        sum += arr[i];
    }

    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("0");
}


Console.WriteLine(firstZeroIndex);
Console.WriteLine(secondZeroIndex);
