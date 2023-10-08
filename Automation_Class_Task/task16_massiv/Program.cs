using System;
using System.Linq;

namespace task16_massiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] squareArray = new int[4, 4]
            {
                { 1, 2, 3, 4 }, 
                { 5, 6, 7, 8 }, 
                { 9, 10, 11, 12 }, 
                { 13, 14, 15, 16 }
            };

            int n = squareArray.GetLength(0); // узнать длину массива 0 (строки) | 1 для (столбца)

            int result = 1; // Инициализируем переменную для хранения произведения (хранение данных из цикла вне цикла) и значение 1 потому что умножая мы получим тот же результат

            for (int i = 0; i < n; i++)
            {
                result *= squareArray[0, i];
            }

            Console.WriteLine("Произведение элементов первой строки: " + result);



            // video n.31 (simplecode c sharp for newbie yt playlist)
            //int[,] array = new int[,]
            //{ //x
            //    { 2, 45, 12, 51, 51 }, //y
            //    { 6, 7, 8, 3, 1 },
            //    { 1, 5, 65, 78, 13 },
            //    { 6, 3, 151, 5, 65}
            //};





            //Console.ReadLine();





            // video n.30 (simplecode c sharp for newbie yt playlist)
            //int[,] array;
            //array = new int[3, 5];

            //int[,] array = new int[3, 5];
            //array[0, 0] = 10;
            //array[0, 1] = 4;
            //array[0, 2] = 99;

            //int[,] array = new int[3, 5]
            //{ //x
            //    { 2, 45, 12, 51, 51 }, //y
            //    { 6, 7, 8, 3, 1 }, 
            //    { 1, 5, 65, 78, 13 }
            //};


            //int[,] array =
            //{ //x
            //    { 2, 45, 12, 51, 51 }, //y
            //    { 6, 7, 8, 3, 1 },
            //    { 1, 5, 65, 78, 13 }
            //};

            //Console.WriteLine(array[0, 2]);






            // video n.26 (simplecode c sharp for newbie yt playlist)
            //int[] array = { 10, 3, 2, 55, 8 };

            //for (int i = 0; i <= array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}



            // video n.25 (simplecode c sharp for newbie yt playlist)
            //int[] array = new int[5];
            //int[] array = new[] {1, 2, 3, 4};
            //int[] array = { 1, 2, 3, 4 };

            //int[] array = Enumerable.Repeat(7, 10).ToArray();
            //Console.WriteLine(array[1]);

            //int[] array = Enumerable.Range(1, 5).ToArray();


            //for (int i = 0; i <= array.Length; i++)
            //{
            //    int sum = array[i] + i;
            //    Console.WriteLine(sum);
            //}




            // video n.24 (simplecode c sharp for newbie yt playlist)
            //int[] n = {1,2,3};

            //Console.WriteLine("First array: "+ n[1]);

            //int n2 = n[2];

            //int[] array;
            //array = new int[5];
            //array[0] = 1;
            //array[1] = 2;
            //array[2] = 3;
            //array[3] = 4;
            //Console.WriteLine("Second array: " + array[0 + n2] + array[1]);

            //Console.WriteLine(array.Length);
        }
    }
}
