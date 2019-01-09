using System;

namespace Kissaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kissaohjelma");

            Cat myFirstCat = new Cat("Pilli", 1);
            myFirstCat.increaseWeight(1);
            myFirstCat.printWeight();
            //Console.WriteLine("Kissan paino on muutettu {0}", myFirstCat.weight);
            Cat mySecondCat = new Cat("Pulla", 3);
            mySecondCat.printWeight();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
