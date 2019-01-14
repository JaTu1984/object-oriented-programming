using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_ohjelma
{
    class Car
    {
        public string brand;
        public int speed;
        public int newSpeed;
        public int brake;

        public Car()
        {

        }

        public Car(string brand, int speed)
        {
            this.brand = brand;
            this.speed = speed;
        }
        public void AskData()

        {
            Console.WriteLine("Anna auton merkki?");
            this.brand = Console.ReadLine();
            Console.WriteLine("Anna auton nopeus?");
            this.speed = int.Parse(Console.ReadLine());

        }

        public string ShowCarInfo()

        {
            return "Auton merkki on " + this.brand +
                  " ja auton nopeus on " + this.speed;
        }

        public int Accelerate()

        {
            Console.WriteLine("Syötä positiivinen nopeuden muutos");
            newSpeed = this.speed + int.Parse(Console.ReadLine());
            {
                if (newSpeed < this.speed)
                    Console.WriteLine("Negatiivinen muutos ei mahdollinen");
                
                else
                    Console.WriteLine("Auton uusi nopeus on ");
                    return newSpeed;
            }

        }

        public int Brake()
        {
            brake = (speed / 10) * 9;
            Console.WriteLine("Auton hidastettu nopeus on ");
            return brake;
        }

    }
}
