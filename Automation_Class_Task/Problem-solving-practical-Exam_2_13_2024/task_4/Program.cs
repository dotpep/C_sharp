// 4.	Введите массив из 12 элементов определенного типа.
// Определите фактическое количество и сумму чисел со значениями, меньшими,
// чем значение последнего элемента.

int[] arr = new int[12] { 2, 8, 5, 10, 1, 7, 2, 0, 9, 8, 7, 3 };

int size = arr.Length;
int last = arr[size - 1];

int sum = 0;
int count = 0;

for (int i = 0; i < size; i++)
{
    if (arr[i] < last)
    {
        sum += arr[i];
        count++;
    }
}

Console.WriteLine("Фактическое количество: " + count);
Console.WriteLine("Сумма чисел меньше последнего элемента: " + sum);
