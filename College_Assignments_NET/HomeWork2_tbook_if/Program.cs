using System;

namespace HomeWork2_tbook_if
{
    internal class Program
    {
        static int a;
        static int b;
        static int c;


        static void Main(string[] args)
        {
            /*             
             * if you want create method without using static (экземпляр класса или структуру)
             * Program program = new Program();
             * Console.WriteLine(program.If1());
             */

            // if1... 3
            input_variable1();
            Console.WriteLine(If1());

            // if4, 5
            //input_variable3();
            //Console.WriteLine(If4());

            // if6... 10
            //input_variable2();
            //Console.WriteLine(If10());
        }


        static int If1()
        {
            if (a > 0)
            {
                a++;
            }

            return a;
        }

        static int If2()
        {
            if (a > 0)
            {
                a++;
            }
            else
            {
                a -= 2;
            }

            return a;
        }

        static int If3()
        {
            if (a > 0)
            {
                a++;
            }
            else if (a == 0)
            {
                a = 10;
            }
            else
            {
                a -= 2;
            }

            return a;
        }

        static void input_variable1()
        {
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
        }

        static int If4()
        {
            int result = 0;
            if (a > 0)
            {
                result++;
            }
            if (b > 0)
            {
                result++;
            }
            if (c > 0)
            {
                result++;
            }

            return result;
        }

        static int If5()
        {
            int positive = 0;
            int negative = 0;

            if (a > 0)
            {
                positive++;
            }
            else if (a < 0)
            {
                negative++;
            }
            if (b > 0)
            {
                positive++;
            }
            else if (b < 0)
            {
                negative++;
            }
            if (c > 0)
            {
                positive++;
            }
            else if (c < 0)
            {
                negative++;
            }

            Console.WriteLine("positive numbers: " + positive);
            Console.WriteLine("negative numbers: " + negative);

            return 0;
        }

        static void input_variable3()
        {
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c: ");
            c = Convert.ToInt32(Console.ReadLine());
        }

        static int If6()
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a < b)
            {
                Console.WriteLine(b);
            }

            return 0;
        }

        static int If7()
        {
            if (a < b)
            {
                Console.WriteLine("a less than b");
            }
            else if (b < a)
            {
                Console.WriteLine("b less than a");
            }
            else
            {
                Console.WriteLine("a equal to b");
            }

            return 0;
        }

        static int If8()
        {
            if (a > b)
            {
                Console.WriteLine($"a: {a} greater than b: {b}");
            }
            else if (b > a)
            {
                Console.WriteLine($"b: {b} greater than a: {a}");
            }
            else
            {
                Console.WriteLine($"a: {a} equal to b: {b}");
            }

            return 0;
        }

        static int If9()
        {
            if (a > b)
            {
                int cont_a = a;
                a = b;
                b = cont_a;
            }

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            return 0;
        }

        static int If10()
        {
            if (a != b)
            {
                int sum = a + b;
                a = sum;
                b = sum;
            }
            else if (a == b)
            {
                a = 0;
                b = 0;
            }

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);

            return 0;
        }

        static void input_variable2()
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
        }
    }
}
