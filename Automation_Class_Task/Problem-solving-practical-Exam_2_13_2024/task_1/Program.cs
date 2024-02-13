namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.	Найдите наименьший элемент массива по модулю.
            int[] array = { 5, 5, -4, 6, 4, 9, -10 };


            // Convert to absolute num of number
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Abs(array[i]);
            }


            // Find minimum number in array
            int min = array[0];

            foreach (int item in array)
            {
                if (min >= item)
                {
                    min = item;
                }
            }

            Console.WriteLine("---");

            // Print array
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n---");

            // Print minimum number in array
            Console.WriteLine(min);
        }
    }
}
