using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    public class PersonModel : BaseModel, IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; } = new Accounts.Accounts();
    }
}