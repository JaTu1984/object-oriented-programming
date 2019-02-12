using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : Shape
    {
        string type;
        string color;
        private double length;
        private double width;
        public Rectangle()
        {
            type = string.Empty;
            color = string.Empty;
            length = 0;
            width = 0;
        }
        public Rectangle(string type, string color, double length, double width)
        {
            this.type = type;
            this.color = color;
            this.length = length;
            this.width = width;
        }
        public override double GetArea()
        {
            double area = length * width;
            return area;
        }
        public override string GetColor()
        {
            return color;
        }
        public override string GetInfo()
        {
            color = GetColor();
            return $"Tyyppi: {type}\nPituus: {length}\nLeveys: {width}\nVäri: {color}\n";
        }
    }
}