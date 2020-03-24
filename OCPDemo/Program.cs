using OCPLibrary;
using OCPLibrary.Accounts;
using OCPLibrary.Applicants;
using System;
using System.Collections.Generic;

namespace OCPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open and Closed Principle : Closed for modification but open for extension
            Console.Write("Welcome to Open/Closed Principle");

            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Azeez", LastName = "Tunde"},
                new ManagerModel { FirstName = "Ade", LastName = "Saka"},
                new ExecutiveModel { FirstName = "Maryam", LastName = "Fareedah"},
                new TechnicianModel { FirstName = "Maryam", LastName = "Fareedah"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach(var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} { emp.LastName } : {emp.EmailAddress}, isManager: {emp.IsManager}, IsExecutive : {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}
