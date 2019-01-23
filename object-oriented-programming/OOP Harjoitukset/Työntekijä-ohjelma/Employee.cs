using System;
using System.Collections.Generic;
using System.Text;

namespace Työntekijä_ohjelma
{
    class Employee
    {
        public string name;
        public string id;
        public string position;
        public int salary;

        public Employee()
        {

        }
        public Employee(string name, string id, string position, int salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public void AskData()
        {
            Console.WriteLine("Anna työntekijän nimi?");
            this.name = Console.ReadLine();
            Console.WriteLine("Anna työntekijän id?");
            this.id = Console.ReadLine();
            Console.WriteLine("Anna työntekijän asema?");
            this.position = Console.ReadLine();
            Console.WriteLine("Anna työntekijän palkka [€]?");
            this.salary = int.Parse(Console.ReadLine());
        }
        public string PrintEmployeeInfo()
        {
            return "Työntekijän nimi on " + this.name +
                " työntekijän id on " + this.id +
                " työntekijän asema on " + this.position +
                " ja työntekijän palkka on " + this.salary;
        }
        public string CompareSalary(Employee Employee)
        {
            string text = "";

            Console.WriteLine($"Nimi: {this.name} - Palkka: {this.salary.ToString()}\n");
            Console.WriteLine($"Nimi: {Employee.name} - Palkka: {Employee.salary.ToString()}\n");

            if (this.salary > Employee.salary)
            {
                text = $"{this.name} on parempipalkkainen kuin {Employee.name}";
            }
            else
            {
                text = $"{Employee.name} on parempipalkkainen kuin {this.name}";
            }
            return text;
        }
    }
}
