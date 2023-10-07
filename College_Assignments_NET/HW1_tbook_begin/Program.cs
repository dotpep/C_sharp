using System;

namespace HW1_tbook_begin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("begin1: ");
            double a = Convert.ToDouble(Console.ReadLine());

            double perimeter = 4 * a;

            Console.WriteLine("output: " + perimeter);
        }
    }
}
