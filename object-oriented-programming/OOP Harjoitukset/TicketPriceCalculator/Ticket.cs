using System;
using System.Collections.Generic;
using System.Text;

namespace TicketPriceCalculator
{
    class Ticket
    {
        public int age;
        public string student;
        public string mtk;
        public string military;
        public double discount;
        public double price;
        public double newPrice;

        public Ticket()
        {
            this.price = 16;
        }
        public Ticket(int age, string student, string mtk, double discount, double price, double newPrice)
        {
            this.age = age;
            this.price = 16;
        }
        public void PrintTicketPrice()
        {
            Console.WriteLine("Ikäsi?");
            age = int.Parse(Console.ReadLine());
            if (age < 7)
                {
                    discount = 100;
                    Console.WriteLine("Alle 7 vuotiaat ilmaiseksi");
                } 
            if (age >= 65)
            {
                discount = 50;
                newPrice = price - (price * discount / 100);
                Console.WriteLine($"Lipun hinta {newPrice}");
                
            }
            if (age >= 7 && age <= 15)
            {
                discount = 50;
                newPrice = price - (price * discount / 100);
                Console.WriteLine($"Lipun hinta {newPrice}");
                
            }
            if (age > 15 && age < 65)
            {
                Console.WriteLine("Oletko opiskelija (k/e)?");
                student = Console.ReadLine();
                Console.WriteLine("Oletko MTK-jäsen (k/e)?");
                mtk = Console.ReadLine();
                Console.WriteLine("Oletko varusmies (k/e)?");
                military = Console.ReadLine();
            }
            if (student == "k" && mtk == "e" && military == "e")
            {
                discount = 45;
                newPrice = price - (price * discount / 100);
                Console.WriteLine($"Lipun hinta {newPrice}");
            }
           
            if (mtk == "k" && student == "e" && military == "e")
            {
                discount = 15;
                newPrice = price - (price * discount / 100);
                Console.WriteLine($"Lipun hinta {newPrice}");
            }
            if (student == "k" && mtk == "k" && military == "e")
            {
                discount = 60;
                newPrice = price - (price * discount / 100);
                Console.WriteLine($"Lipun hinta {newPrice}");
            }

            if (military == "k" && student == "e" && mtk == "e")
            {
                discount = 50;
                newPrice = price - (price * discount / 100);
                Console.WriteLine($"Lipun hinta {newPrice}");
            }
        }
    }
}
