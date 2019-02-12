using System;

namespace Rajapinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on rajapintaohjelma");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Product product1 = new Product();
            product1.GetProduct();
            Console.ReadLine();
            product1.CalculateTotal();
            Console.WriteLine();
            Product[] array1 = new Product[3];
            Console.WriteLine();
            Customer customer1 = new Customer();
            customer1.GetCustomer();
            Console.ReadLine();
            customer1.GetBonus();
            Console.WriteLine();
            Customer[] array2 = new Customer[3];
            Store store = new Store();
            store.AddProduct(product1);
            store.AddCustomer(customer1);
            store.PrintCustomers();
            store.PrintProducts();
        }
    }
}
