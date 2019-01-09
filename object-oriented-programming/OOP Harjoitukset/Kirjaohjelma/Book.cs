using System;
using System.Collections.Generic;
using System.Text;

namespace Kirjaohjelma
{
    class Book
    {
        public string title;
        public string author;
        public string id;
        public double price;

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.id = id;
            this.price = price;
        }

        public string PrintInfo()
        {

            //{Console.WriteLine($"Kirjan nimi on {this.title}\n" +
            //$"tekijä on {this.author}\n" +
            //$"kirjan id on {this.id}\n" +
            //$"ja kirjan hinta on {this.price}");
            //}
            return "Kirjan nimi on " + this.title +
                  " tekijä on " + this.author +
                  " kirjan id on " + this.id +
                  " ja kirjan hinta on " + this.price;
        }
        public string CompareBooks(Book Book)
        {
            string text = "";

            Console.WriteLine($"Nimi: {this.title} - Hinta: {this.price.ToString()}\n");
            Console.WriteLine($"Nimi: {Book.title} - Hinta: {Book.price.ToString()}\n");

            if (this.price > Book.price)
            {
                text = $"{this.title} on kalliimpi kuin {Book.title}";
            }
            else
            {
                text = $"{Book.title} on kalliimpi kuin {this.title}";
            }
            return text;
        }
    }
}
