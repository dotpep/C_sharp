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

        static void Main(string[] args)
        {
            Console.Write("begin: ");
            double n = Convert.ToDouble(Console.ReadLine());

            //Begin1 begin1 = new Begin1();

            double result = Begin1(n);

            Console.WriteLine("output: " + result);
        }
    }
}
