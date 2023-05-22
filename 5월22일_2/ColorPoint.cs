using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ColorPoint:Point
    {
        private string color;

        public void setColor(string color) { this.color = color; }

        public void showColorPoint()
        {
            Console.Write(color);
            showPoint();
        }
    }


}
