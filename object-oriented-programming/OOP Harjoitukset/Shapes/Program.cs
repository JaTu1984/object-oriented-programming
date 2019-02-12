using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("ympyrä", "sininen", 35);
            Rectangle rectangle = new Rectangle("nelikulmio", "vihreä", 50, 25);
            Triangle triangle = new Triangle("kolmio", "keltainen", 45, 80);
            List<Shape> shapeList = new List<Shape>();
            shapeList.Add(circle);
            shapeList.Add(rectangle);
            shapeList.Add(triangle);
            foreach (Shape shape in shapeList)
            {
                Console.WriteLine(shape.GetInfo());
            }
            Console.WriteLine("-------------");
            Console.WriteLine();
            foreach (Shape shape in shapeList)
            {
                if (shape is Circle)
                {
                    Console.WriteLine($"{shape.GetInfo()}");
                }
            }
            Console.WriteLine("Paina enter jatkaaksesi...");
            Console.ReadLine();
        }
    }
}