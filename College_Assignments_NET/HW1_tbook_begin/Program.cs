using System;

namespace HW1_tbook_begin
{
    internal class Program
    {

        double Begin1(double a)
        {
            double perimeter = 4 * a;
            return perimeter;
        }

        static void Main(string[] args)
        {
            Console.Write("begin: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Program program = new Program(); // выделение памяти для нового обьекта в классе
            double result = program.Begin1(n); // использование метода в нашем классе и передать аргумент для метода

            Console.WriteLine("output: " + result);
        }
    }
}
