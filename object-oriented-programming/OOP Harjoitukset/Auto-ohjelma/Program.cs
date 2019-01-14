using System;

namespace Auto_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on auto-ohjelma");

            Car myCar = new Car();
            myCar.AskData();
            Console.WriteLine(myCar.ShowCarInfo());
            Console.WriteLine(myCar.Accelerate());
            Console.WriteLine(myCar.Brake());
            Car secondCar = new Car();
            secondCar.AskData();
            Console.WriteLine(secondCar.ShowCarInfo());
            

        }
    }
}
