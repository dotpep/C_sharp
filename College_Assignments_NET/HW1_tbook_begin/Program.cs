using System;

namespace HW1_tbook_begin
{
    internal class Program
    {

        static double Begin1(double a)
        {
            double perimeter = 4 * a;
            return perimeter;
        }

        static double Begin2(double a)
        {
            double square = a * a;
            return square;
        }

        static void Begin3(double a, double b, out double area, out double perimeter)
        {
            area = a * b;
            perimeter = 2 * (a + b);
        }

        static double Variable()
        {
            Console.Write("n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double result = Begin2(n);
            return result;
        }

        static void Variable_2x()
        {
            Console.Write("a: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            // method change
            Begin3(n, n2, out double a, out double b);
            Console.WriteLine($"First: {a}, Second: {b}");
        }

        static void Main(string[] args)
        {
            // for 1 variable input
            //Console.WriteLine("output: " + Variable());

            // call void method
            Variable_2x();
        }
    }
}
