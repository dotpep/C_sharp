using System;

namespace n59_encapsulation_opp_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(x: 5, y: 3);
            point.Print();
        }
    }


    class Point
    {
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        private int _x;
        private int _y;

        public void Print()
        {
            Console.WriteLine($"x: {_x}\tY: {_y}");
        }

    }
}
