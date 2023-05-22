using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        private int x, y;

        public Point() { }

        public void set(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void showPoint()
        {
            Console.WriteLine($"({x}, {y})");
        }
    }
}