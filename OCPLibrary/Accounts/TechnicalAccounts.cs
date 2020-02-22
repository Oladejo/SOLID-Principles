using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    public class TechnicalAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            var employee = EmployeeCapture.CreateEmployee(person);
            employee.IsExecutive = true;

            return employee;
        }
    }
}
