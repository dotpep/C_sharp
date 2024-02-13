// 27.	Вычислите сумму первых n чисел Фибоначчи. F(0)=0, F(1)=1, F(2)=1, F(n)= F(n-1)+F(n-2).
// Используйте рекурсию при вычислениях.


static int Fibannaci(int num) // 0, 1, 1, 2, 3, 5, 8, 13, 21
{
    if (num == 0)
    {
        return 0;
    }
    else if (num == 1)
    {
        return 1;
    }

    return Fibannaci(num - 1) + Fibannaci(num - 2); // на каждый последующий самого себя (начиная с 0 и 1)
}

static int SumFibannaci(int num)
{
    int sum = 0;

    for (int i = 0; i < num; i++)
    {
        sum += Fibannaci(i);
    }

    return sum;
}


static void Main()
{
    int num = 10;

    int result = SumFibannaci(num);

    Console.WriteLine(result);
}

Main();
