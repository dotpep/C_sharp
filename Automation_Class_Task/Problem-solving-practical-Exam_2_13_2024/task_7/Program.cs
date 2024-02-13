// 7.	Дан массив из 19 элементов целочисленного типа.
// Найдите сумму элементов, которая предшествует первому отрицательному элементу.

// В алфавите буква "а" предшествует букве "б".
// то есть предшествует это значит что находиться раньше другуго элемента

const int size = 19;
int[] arr = new int[size] { 2, 4, 9, 2, 5, -9, 10, 5, 9, 8, 4, 6, -2, 1, 5, 1, 3, -5, 6 };

int sum = 0;

for (int i = 0; i < size; i++)
{
	if (arr[i] < 0)
        break;

	sum += arr[i];
}

Console.WriteLine(sum);


//int negative_index = 0;

//for (int i = 0; i < size; i++)
//{
//    if (arr[i] < 0)
//    {
//        negative_index = i;
//        break;
//    }
//}

//Console.WriteLine(negative_index);


//int sum = 0;

//for (int i = negative_index - 1; i > 0; i--)
//{
//    sum += arr[i];
//}

//int sum2 = 0;

//for (int i = 0; i <= negative_index; i++)
//{
//    sum2 += arr[i];
//}


//Console.WriteLine(sum);
//Console.WriteLine(sum2);
