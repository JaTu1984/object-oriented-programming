using System;
using System.Collections.Generic;
using System.Text;

namespace KulkuValine
{
    class Truck : Car
    {
        public double weight;
        public double consumption;

        public Truck()
        {
            this.weight = 1000;
            this.consumption = 100;
        }
        public Truck(double weight, double consumption)
        {
            this.weight = weight;
            this.consumption = consumption;
        }
        public double CalculateConsumption()
        {
            double calculation;

            calculation = weight / consumption;
            Console.WriteLine($"Laskettu kulutus on {calculation}");
            return 0;
        }
    }
}
