using System;

namespace HomeWork3_tbook_switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Mon");
                    break;
                case 2:
                    Console.WriteLine("Tue");
                    break;
                case 3:
                    Console.WriteLine("Wed");
                    break;
                case 4:
                    Console.WriteLine("Thu");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                case 7:
                    Console.WriteLine("Sun");
                    break;

                default: 
                    Console.WriteLine("week errors (1-7)");
                    break;

            }
        }
    }
}
