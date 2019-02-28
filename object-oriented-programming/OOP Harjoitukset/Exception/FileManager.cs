using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FileManager
{
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {
        }
    }
    class FileManager
    {
        private string filePath;
        public FileManager()
        {
            this.filePath = @"C:\Users\janne\OneDrive\Työpöytä\Koulu\dev\object-oriented-programming\filemanager\cat.json";
        }
        public string ReadWords()
        {
            string content = String.Empty;
            try
            {
                content = ReadFile();
                return content;
            }
            catch (WordListNotFoundException e)
            {
                return e.Message;
            }
            catch (FileNotFoundException e)
            {
                return e.Message;
            }
        }
        private string ReadFile()
        {
            if (File.Exists(filePath))
            {
                List<Cat> catList = JsonConvert.DeserializeObject<List<Cat>>(File.ReadAllText(this.filePath));
                Console.WriteLine($"There are {catList.Count} cats on the list.");
                foreach (Cat cat in catList)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Name: {cat.Name}\nAge: {cat.Age}\nColor: {cat.Color}");
                }
            }
            else if (!File.Exists(filePath))
            {
                throw new WordListNotFoundException("File not found.");
            }
            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);
            Console.WriteLine();
            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);
            return "";
        }
    }
}