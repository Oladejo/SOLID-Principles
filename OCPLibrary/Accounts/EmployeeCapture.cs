using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    public class EmployeeCapture
    {
        public static EmployeeModel CreateEmployee(IApplicantModel person)
        {
            EmployeeModel employee = new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{ person.FirstName.Substring(0, 1) }{person.LastName}@heyzed.com"
            };

            return employee;
        }
    }
}
