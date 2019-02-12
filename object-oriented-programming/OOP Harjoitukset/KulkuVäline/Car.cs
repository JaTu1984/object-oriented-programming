using System;
using System.Collections.Generic;
using System.Text;

namespace KulkuValine
{
    class Car : Vehicle
    {
        protected double engine;
        protected string model;
        protected int doors;

        public Car()
        {
            Console.WriteLine("CAR Constructor");
            this.engine = 1000;
            this.model = "";
            this.doors = 0;
        }
        public Car(double engine, string model, int doors)
        {
            Console.WriteLine("CAR Constructor");
            this.engine = engine;
            this.model = model;
            this.doors = doors;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Moottori on {engine}\n" +
                              $"malli on {model}\n" +
                              $"ja ovien lukumäärä on {doors}\n");
        }
        public override string ToString()
        {
            Console.WriteLine($"{engine} {model} {doors}");
            return ($"{base.ToString()}");
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

    }
}
