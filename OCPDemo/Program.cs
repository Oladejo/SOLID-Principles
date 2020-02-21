using OCPLibrary;
using System;
using System.Collections.Generic;

namespace OCPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Azeez", LastName = "Tunde"},
                new PersonModel { FirstName = "Ade", LastName = "Saka"},
                new PersonModel { FirstName = "Maryam", LastName = "Fareedah"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach(var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} { emp.LastName } : {emp.EmailAddress}");
            }

            Console.ReadLine();
        }
    }
}
