using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            //var employee = EmployeeCapture.CreateEmployee(person);

            //The above code can not be use here before the email format is different.
            //Someone need to be careful when using the CreateEmployee class

            EmployeeModel employee = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{ person.FirstName.Substring(0, 3) }{person.LastName}@heyzed.com"
            };

            employee.IsManager = true;
            return employee;
        }
    }
}