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
            //Console.WriteLine(firstEmployee.PrintEmployeeInfo());
            Employee secondEmployee = new Employee();
            secondEmployee.AskData();
            //Console.WriteLine(secondEmployee.PrintEmployeeInfo());
            firstEmployee.CompareSalary(secondEmployee);
            Console.WriteLine(firstEmployee.CompareSalary(secondEmployee));
            Console.ReadKey();
            Employee[] employees = new Employee[3];
            employees[0] = firstEmployee;
            employees[1] = secondEmployee;
            foreach (Employee employee in employees)
            {
                employee.PrintEmployeeInfo();
            }
        }
    }
}
