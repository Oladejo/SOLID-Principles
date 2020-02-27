using LSPLibrary;
using System;

namespace LSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Azeez";
            accountingVP.LastName = "Tunde";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Employee();
            emp.FirstName = "Maryam";
            emp.LastName = "Azeez";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName }'s salary is ${emp.Salary}/hour");

            Console.ReadLine();
        }
    }
}
