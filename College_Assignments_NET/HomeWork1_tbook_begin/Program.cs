using System;
using System.Xml.Schema;

namespace HomeWork1_tbook_begin
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

        static double Begin4(double a)
        {
            double pi = 3.14;
            double length = pi * a;
            return length;
        }

        static void Begin5(double a, double b, double n, out double volume, out double area)
        {
            volume = a * b * n;
            area = 2 * (a * b + a * n + b * n);
        }

        static void Begin6(double a, out double length, out double area)
        {
            double pi = 3.14;
            length = 2 * pi * a;
            area = pi * a * a;
        }

        static double Begin7(double a, double b)
        {
            double average = (a + b) / 2;
            return average;
        }

        static double Begin8(double a, double b)
        {
            double geo_average = Math.Sqrt(a * b);
            return geo_average;
        }

        static void Begin9(double a, double b)
        {
            double square_a = a * a;
            double square_b = a * b;

            double sum = square_a + square_b;
            double difference = square_a - square_b;
            double content = square_a * square_b;
            double personal = square_a / square_b;

            Console.WriteLine($"сумма: {sum}, разница: {difference}, произведение: {content}, частное: {personal}");
        }

        static void Begin10(double a, out double volume, out double area)
        {
            volume = a * a * a;
            area = 6 * a * a;
        }

        static void Variable()
        {
            Console.Write("n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            // method choose
            //double result = Begin4(n);
            //Console.WriteLine("output: " + result);

            // 1 input 2 output
            Begin10(n, out double a, out double b);
            Console.WriteLine($"a: {a}, b: {b}");
        }

        static void Variable_2x()
        {
            Console.Write("a: ");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            // method choose
            //Begin3(n, n2, out double a, out double b);

            // begin 5
            //Console.Write("c: ");
            //double n3 = Convert.ToDouble(Console.ReadLine());
            //Begin5(n, n2, n3, out double a, out double b);


            //Console.WriteLine($"First: {a}, Second: {b}");

            // 2 argument 1 output
            //Console.WriteLine(Begin8(n, n2));

            // 2 args 4 output
            Begin9(n, n2);
        }

        static void Main(string[] args)
        {
            // for 1 variable input
            Variable();


            // call void method
            //Variable_2x();

        }
    }
}
