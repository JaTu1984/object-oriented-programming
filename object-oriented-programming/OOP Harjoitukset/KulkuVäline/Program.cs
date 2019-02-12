using System;

namespace KulkuValine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kulkuvalineohjelma");
            Car car1 = new Car(1500, "Coupe", 4);
            car1.PrintInfo();
            car1.ToString();
            Truck truck1 = new Truck(1000, 100);
            truck1.CalculateConsumption();
            Console.WriteLine();
        }
    }
}
