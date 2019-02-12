using System;
using System.Collections.Generic;
using System.Text;

namespace Rajapinta
{
    class Product : IProduct
    {
        public string productName;
        public double price;
        public int amount;

        public Product()
        {
            this.productName = "";
            this.price = 0;
            this.amount = 0;
        }
        public override string ToString()
        {
            Console.WriteLine($"{productName} {price} {amount}");
            return ("");
        }
        public Object GetProduct()
        {
            Console.WriteLine("Mikä tuote?");
            return "";
        }
        public double CalculateTotal()
        {
            double total;
            Console.WriteLine("Anna kappalemäärä?");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna hinta?");
            price = int.Parse(Console.ReadLine());
            total = price * amount;
            Console.WriteLine($"Kokonaishinta on {total} €");
            return 0;
        }
    }
}
