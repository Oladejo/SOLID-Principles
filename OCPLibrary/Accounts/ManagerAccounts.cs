using OCPLibrary.Applicants;

namespace OCPLibrary.Accounts
{
    public class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            var employee = EmployeeCapture.CreateEmployee(person);
            employee.IsManager = true;
            return employee;
        }
    }
}
