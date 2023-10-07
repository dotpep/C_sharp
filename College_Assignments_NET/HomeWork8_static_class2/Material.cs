using System;

namespace HomeWork2
{
    static class Material
    {
        static string second_name = "Гидроксид водорода";
        static int second_element = 1;

        static string element_connection = "Вода (H2O)";


        public static int Table(string name, int element)
        {

            if (element == 8)
            {
                Console.WriteLine($"{name}, ({element}) + {second_name}, ({second_element}) = {element_connection}");
            }
            else
            {
                Console.WriteLine("Ничего не выйдет от этого соеденение элементов");
            }


            return 0;
        }


    }
}
