// 16.	Найдите сумму 1+2+3+...+n, где пользователь вводит n из компилятора.

Console.Write("calculate using (1+2+3+...+n): ");
int userInput = Convert.ToInt16(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= userInput; i++)
{
    sum += i;
}

Console.WriteLine($"Sum of 1+2+3+...+{userInput}={sum}");
