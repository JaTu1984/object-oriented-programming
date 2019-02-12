using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        string type;
        string color;
        private double radius;

        public Circle()
        {
            type = string.Empty;
            color = string.Empty;
            radius = 0;
        }
        public Circle(string type, string color, double radius)
        {
            this.type = type;
            this.color = color;
            this.radius = radius;
        }
        public override double GetArea()
        {
            double pi = Math.PI;
            double area = radius * radius * pi;
            return area;
        }
        public override string GetColor()
        {
            return color;
        }
        public override string GetInfo()
        {
            color = GetColor();
            return $"Tyyppi: {type}\nSäde: {radius}\nVäri: {color}\n";
        }
    }
}