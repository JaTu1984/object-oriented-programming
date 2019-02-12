using System;
using System.Collections.Generic;
using System.Text;
using TaskBook2;

namespace Literature
{
    class Author
    {
        private string _name;
        private string _birthday;
        private Book _book;

        public Author(string name, string birthday, Book book)
        {
            _name = name;
            _birthday = birthday;
            _book = book;
        }

        public void PrintData()
        {
            Console.WriteLine($"===================\n" +
                              $"Kirjailija: {_name}\n" +
                              $"Syntymäpäivä: {_birthday}\n" +
                              $"Kirja:\n" +
                              $"===================\n" +
                              $"{_book.ToString()}");

        }
    }
}