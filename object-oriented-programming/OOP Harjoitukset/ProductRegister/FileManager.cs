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
        private string filePathTest;
        public FileManager()
        {
            this.filePath = @"C:\Users\janne\OneDrive\Työpöytä\Koulu\dev\object-oriented-programming\productregister\items.json";
            this.filePathTest = @"C:\Users\janne\OneDrive\Työpöytä\Koulu\dev\object-oriented-programming\productregister\itemsTest.json";
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
            if (File.Exists(filePath))
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
        public void ManageComment()
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));
            int i = 0; 
            foreach (Item item in itemList)
            {
                Console.WriteLine($"{i + 1}. {item.Name}");
                i++;
            }
            Console.WriteLine("Syötä haluamasi tuotteen tarkka nimi lisätäksesi kommentin.");
            string itemToComment = Console.ReadLine();
            bool isFound = false; 
            foreach (Item item in itemList)
            {
                if (item.Name == itemToComment)
                {
                    isFound = true; // set true to continue
                    Console.WriteLine("Syötä A lisätäksesi kommentin tai D poistaaksesi kommentin.");
                    string choice = Console.ReadLine().ToUpper();
                    if (choice == "A")
                    {
                        Console.WriteLine("Kommenttisi: ");

                        string newComment = Console.ReadLine();
                        if (item.Comment.Replace("   ", "") != newComment) 
                        {
                            item.Comment += newComment + "   ";
                            File.WriteAllText(filePath, JsonConvert.SerializeObject(itemList));
                            Console.WriteLine($"Kommentti lisätty onnistuneesti: {newComment}");
                        }
                        else if (item.Comment.Replace("   ", "") == newComment)
                        {
                            Console.WriteLine("Ei voi syöttää samaa kommenttia kahdesti. Kommentin lisäys epäonnistui.");
                        }
                    }
                    else if (choice == "D")
                    {
                        Console.WriteLine($"Deleted comment(s): {item.Comment}");
                        item.Comment = ""; 
                        File.WriteAllText(filePath, JsonConvert.SerializeObject(itemList));
                    }
                    else
                    {
                        Console.WriteLine("Väärä syöte.");
                    }
                }
            }
            if (isFound != true) 
            {
                Console.WriteLine("Tuotetta ei löytynyt.");
            }
        }
    }
}