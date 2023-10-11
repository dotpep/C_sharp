using System;

namespace HomeWork5_array
{
    internal class Program
    {
        static int[,] array = {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

        static void Main(string[] args)
        {
            Array_Vertical();

        }
        
        static int Array_Diagonal()
        {
            //Console.WriteLine(array[0, 0]);
            //Console.WriteLine(array[1, 1]);
            //Console.WriteLine(array[2, 2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i, i]);
            }

            return 0;
        }

        static int Array_Vertical()
        {
            //Console.WriteLine(array[0, 0]);
            //Console.WriteLine(array[1, 0]);
            //Console.WriteLine(array[2, 0]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[i, 0]);
            }

            return 0;
        }


        static int Array_Horizontal()
        {
            //Console.WriteLine(array[2, 0]);
            //Console.WriteLine(array[2, 1]);
            //Console.WriteLine(array[2, 2]);

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[2, i]);
            }

            return 0;
        }

    }
}
