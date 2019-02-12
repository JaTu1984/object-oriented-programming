using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    abstract class Shape
    {
        private string type;
        private string color;
        public virtual double GetArea() { return 0; }
        public virtual string GetInfo() { return null; }
        public virtual string GetColor() { return null; }
    }
}
