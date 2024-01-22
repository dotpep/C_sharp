using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите сумму: ");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a % 10 != 0) // % (калдыкпен болу) != (тен емес) - (55)5 - 555 % 10 = 5 = 0
        {
            Console.WriteLine("Невозможно выплатить.");
        }

        Console.WriteLine("Выплата:");

        int rub100 = a / 100; // 550 / 100 = 5
        a %= 100; // 550 = 50

        if (rub100 > 0)
            Console.WriteLine($"100 рублей: {rub100}");

        int rub50 = a / 50;
        a %= 50;

        if (rub50 > 0)
            Console.WriteLine($"50 рублей: {rub50}");

        int rub10 = a / 10;

        if (rub10 > 0)
            Console.WriteLine($"10 рублей: {rub10}");


    }
}
