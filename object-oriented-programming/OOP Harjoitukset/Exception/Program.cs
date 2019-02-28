using System;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            Console.WriteLine(fileManager.ReadWords());
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}