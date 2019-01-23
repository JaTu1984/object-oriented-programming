using System;

namespace Työntekijä_ohjelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on työntekijäohjelma:");

            Employee firstEmployee = new Employee();
            firstEmployee.AskData();
            Console.WriteLine(firstEmployee.PrintEmployeeInfo());
            Employee secondEmployee = new Employee();
            secondEmployee.AskData();
            Console.WriteLine(secondEmployee.PrintEmployeeInfo());
            firstEmployee.CompareSalary(secondEmployee);
            Console.WriteLine(firstEmployee.CompareSalary(secondEmployee));
            Console.ReadKey();
        }
    }
}
