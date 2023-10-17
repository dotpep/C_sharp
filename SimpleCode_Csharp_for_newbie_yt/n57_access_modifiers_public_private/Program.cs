using System;
using System.Reflection;

namespace n57_access_modifiers_public_private
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Point point = new Point();

            //point.x = 10;
            //point.PrintY();


            //point.PrintPoint();


            // prove
            //point.z;
            var typeInfo = typeof(Point).GetFields(BindingFlags.Instance |
                BindingFlags.NonPublic |
                BindingFlags.Public);

            foreach (var item in typeInfo)
            {
                Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate}\t IsPublic: {item.IsPublic}");
            }

        }
    }



    class Point
    {
        int z = 3; // default using private

        public int x = 1;
        private int y = 44;


        private void PrintX()
        {
            Console.WriteLine("x: " + x);
        }

        public void PrintY()
        {
            Console.WriteLine("y: " + y);
        }

        public void PrintPoint()
        {
            PrintX();
            PrintY();
        }

    }
}
