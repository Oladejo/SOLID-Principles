using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    public class ManagerModel : BaseModel, IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; } = new ManagerAccounts();
    }
}
