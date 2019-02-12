using System;
using System.Collections.Generic;
using System.Text;

namespace KulkuValine
{
    abstract class Vehicle
    {
        protected string type1;
        protected string mark;
        protected int yearModel;
        protected int price;

        public Vehicle()
        {
            this.type1 = "Toyota";
            this.mark = "RAV4";
            this.yearModel = 1990;
            this.price = 10000;
        }
        public Vehicle(string type1, string mark, int yearModel, int price)
        {
            this.type1 = type1;
            this.mark = mark;
            this.yearModel = yearModel;
            this.price = price;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Auton tyyppi on {type1}\n" +
                   $"auton merkki on {mark}\n" +
                   $"auton vuosimalli on {yearModel}\n" +
                   $"auton hinta on {price}\n");
        }
        public override string ToString()
        {
            Console.WriteLine($"{type1} {mark} {yearModel} {price}");
            return ($"{type1} {mark} {yearModel} {price}");
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
