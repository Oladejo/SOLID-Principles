using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    public class ExecutiveModel : BaseModel, IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; } = new ExecutiveAccounts();
    }
}
