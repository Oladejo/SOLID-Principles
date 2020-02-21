namespace OCPLibrary
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person)
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