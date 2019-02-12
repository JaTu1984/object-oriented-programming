using System;
using System.Collections.Generic;
using System.Text;

namespace Rajapinta
{
    class Store : ICustomers, IProducts
    {
        public string name;
        public double sales;
        List<Product> products = new List<Product>();
        List<Customer> customers = new List<Customer>();
        public Store()
        {
            name = string.Empty;
            sales = 0;
        }
        public Store(string name, double sales)
        {
            this.name = name;
            this.sales = sales;
        }
        public Store(List<Product> products, List<Customer> customers)
        {
            this.products = products;
            this.customers = customers;
        }
        public override string ToString()
        {
            return ($"Kaupan nimi: {name}" +
                    $"\nLiikevaihto: {sales}€");
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void PrintProducts()
        {
            Console.WriteLine($"Tuotteiden lukumäärä kaupassa: {products.Count}");
            Console.WriteLine($"Asiakkaiden lukumäärä kaupassa: {customers.Count}\n");
            Console.WriteLine(new string('-', 33));
            foreach (Product product in products)
            {
                Console.WriteLine(product);
                Console.WriteLine(product.CalculateTotal());
            }
        }
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }
        public void PrintCustomers()
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine($"Bonusta kertynyt: {customer.GetBonus()}€\n");
            }
        }
        void ICustomers.AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
        void ICustomers.PrintCustomers()
        {
            throw new NotImplementedException();
        }
    }
}

