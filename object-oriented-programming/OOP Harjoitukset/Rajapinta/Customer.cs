using System;
using System.Collections.Generic;
using System.Text;

namespace Rajapinta
{
    class Customer
    {
        public string customerName;
        public double buyings;
        public Customer()
        {
            this.customerName = "";
            this.buyings = 0;
        }
        public override string ToString()
        {
            return ($"{customerName} {buyings}");
        }
        public Object GetCustomer()
        {
            Console.WriteLine("Anna asiakkaan nimi?");
            return "";
        }
        public double GetBonus()
        {
            double bonus;
            Console.WriteLine("Anna laskettu kokonaishinta");
            buyings = int.Parse(Console.ReadLine());
            if (buyings < 1000)
            {
                bonus = 0.02 * buyings;
                Console.WriteLine($"Bonus on {bonus} €");
            }
            if (buyings >= 1000 && buyings <= 2000)
            {
                bonus = 0.03 * buyings;
                Console.WriteLine($"Bonus on {bonus} €");
            }
            if (buyings > 2000)
            {
                bonus = 0.05 * buyings;
                Console.WriteLine($"Bonus on {bonus} €");
            }
            return 0;
        }
        public string GetCustomer(string customerName)
        {
            if (this.customerName.Equals(customerName))
            {
                return ToString();
            }
            else
            {
                return null;
            }

        }
    }
}
