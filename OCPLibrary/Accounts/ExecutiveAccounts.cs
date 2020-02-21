using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            var employee = EmployeeCapture.CreateEmployee(person);
            employee.IsManager = true;
            employee.IsExecutive = true;

            return employee;
        }
    }
}
