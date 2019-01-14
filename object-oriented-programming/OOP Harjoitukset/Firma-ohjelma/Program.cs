using System;

namespace Firma_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Tämä on firmaohjelma:");

            Firm myFirm = new Firm();
            myFirm.AskData();
            Console.WriteLine(myFirm.ShowFirmInfo());
            Firm firm2 = new Firm(myFirm);
            Console.WriteLine(firm2.ShowFirmInfo());
            Console.WriteLine(myFirm.Winning());
            Console.ReadKey();

        }
    }
}
