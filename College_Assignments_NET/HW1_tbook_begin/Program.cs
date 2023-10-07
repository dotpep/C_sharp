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

        static double Begin3(double a, double b)
        {
            double area = a * b;
            double perimeter = 2 * (a + b);
            return area;
        }

        static double Variable()
        {
            Console.Write("input: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double result = Begin2(n);
            return result;
        }

        static double Variable_2x()
        {
            Console.Write("input: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("input 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            double result = Begin3(n, n2);
            return result;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("output: " + Variable());
            Console.WriteLine("output: " + Variable_2x());
        }
    }
}
