using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProductRegister
{
    class FileManager
    {
        private string filePath;
        public FileManager()
        {
            this.filePath = @"C:\Users\janne\OneDrive\Työpöytä\Koulu\dev\object-oriented-programming\productregister\items.json";
        }
        public string ListItems()
        {
            string listContent = String.Empty;
            try
            {
                listContent = ReadFile();
                return listContent;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        private string ReadFile()
        {
            if (File.Exists(filePath)) // deserialize the json-file, if it exists, into a list
            {
                List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));
                foreach (Item item in itemList)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}");
                }
                Console.WriteLine();
                Console.WriteLine("Haluatko saada tuotteen kaikki tiedot? K/E");
                string response = Console.ReadLine().ToUpper();
                if (response == "K")
                {
                    Console.WriteLine("Anna tuotenumero: ");
                    string inputId = Console.ReadLine();
                    foreach (Item item in itemList)
                    {
                        if (inputId == item.Id)
                        {
                            Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ei tuotteita.");
                }
            }
            else if (!File.Exists(filePath)) // Exception handler
            {
                throw new Exception("Tiedostoa ei löydy.");
            }
            return "";
        }
        public string PrintProductGroup(string group)
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));
            foreach (Item item in itemList)
            {
                if (group == "1")
                {
                    if (item.GroupName == "Lajittelu ja säilytys")
                    {
                        Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                    }
                }
                else if (group == "2")
                {
                    if (item.GroupName == "Paperit ja lehtiöt")
                    {
                        return $"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n";
                    }
                }
                else if (group == "3")
                {
                    if (item.GroupName == "Kynät")
                    {
                        return $"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n";
                    }
                }
                else if (group == "4")
                {
                    if (item.GroupName == "Kortit ja kirjekuoret")
                    {
                        return $"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n";
                    }
                }
                else
                {
                    return "Virheellinen syöte.";
                }
            }
            return "";
        }
        public void PrintRanOut()
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));
            foreach (Item item in itemList)
            {
                if (item.Amount == 0)
                {
                    Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                }
            }
        }
    }
}