using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    public class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            var employee = EmployeeCapture.CreateEmployee(person);
            
            return employee;
        }
    }
}