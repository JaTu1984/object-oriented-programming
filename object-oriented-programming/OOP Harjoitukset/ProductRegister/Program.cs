using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ProductRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            FileManager fileManager = new FileManager();
            string userInput = null;
            string message = "";
            do
            {
                userInput = ChooseAction();
                switch (userInput.ToUpper())
                {
                    case "A":
                        Console.WriteLine(fileManager.ListItems());
                        break;
                    case "B":
                        Console.WriteLine("Valitse tuoteryhmä:");
                        Console.WriteLine("1 = Lajittelu ja säilytys");
                        Console.WriteLine("2 = Paperit ja lehtiöt");
                        Console.WriteLine("3 = Kynät");
                        Console.WriteLine("4 = Kortit ja kirjekuoret");
                        string group = Console.ReadLine();
                        Console.WriteLine(fileManager.PrintProductGroup(group));
                        break;
                    case "C":
                        fileManager.PrintRanOut();
                        break;
                    case "D":
                        fileManager.ManageComment();
                        break;
                    case "E":
                        message = "\nSuljetaan ohjelma.";
                        break;
                    default:
                        message = "Virheellinen valinta.";
                        break;
                }
                Console.WriteLine(message);
                Console.ReadKey();
                Console.Clear();
            }
            while (userInput.ToUpper() != "E");
        }
        public static string ChooseAction()
        {
            Console.WriteLine("TUOTEREKISTERI\nValitse toiminto ja paina ENTER:");
            Console.WriteLine("[ A ] = Listaa kaikki tuotteet");
            Console.WriteLine("[ B ] = Listaa tuoteryhmän mukaan");
            Console.WriteLine("[ C ] = Listaa loppuneet tuotteet");
            Console.WriteLine("[ D ] = Lisää tai poista tuotteen kommentti.");
            Console.WriteLine("[ E ] = Sulje ohjelma.");
            string action = Console.ReadLine();
            return action;
        }
    }
}