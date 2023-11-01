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
            Test2();
        }
        
        static int Test1()
        {
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6}, 
                {7, 8, 9}
            };


            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                Console.WriteLine(matrix[i, i]);
            }

            return 0;

        }

        static int Test2()
        {
            int[,] array = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8 , 9}
            };

            int[,] matrix = {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            // array stairs
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++) // j <= i
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


            // symbols stairs
            int n;
            Console.Write("\n n: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }



            Console.WriteLine();



            // binary code convert formula 2^1
            for (int i = 7; i >= 1; --i)
            {
                Console.Write($"2^{i}" + "\t ");
            }

            Console.WriteLine(" ");
            for (int i = 7; i >= 1; --i)
            {
                Console.Write(Math.Pow(2, i) + "\t ");
            }
            Console.WriteLine();

            return 0;
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
