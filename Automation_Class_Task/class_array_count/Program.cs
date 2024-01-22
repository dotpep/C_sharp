using System;

namespace class_array_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    int count;

                    if (array[i] == array[j + 1])
                    {
                        count = array[i];
                    }
                }
            }

        }
    }
}
