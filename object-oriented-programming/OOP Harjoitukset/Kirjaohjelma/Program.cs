using System;

namespace Kirjaohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kirjaohjelma");
            Console.WriteLine("Kirjat:");

            Book myBook = new Book("Aapinen",
                                   "Mikael Agricola",
                                   "00001",
                                   22.50);

            //myBook.PrintInfo();

                Console.WriteLine("********** " + myBook.PrintInfo());

            Book secondBook = new Book("Peppi Pitkätossu", "Astrid Lindgren", "00002", 19.50);
            Console.WriteLine(secondBook.PrintInfo());

            myBook.CompareBooks(secondBook);
            Console.WriteLine(myBook.CompareBooks(secondBook));

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
