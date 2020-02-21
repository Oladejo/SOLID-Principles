using OCPLibrary.Accounts;

namespace OCPLibrary.Applicants
{
    public class TechnicianModel : BaseModel, IApplicantModel
    {
        public IAccounts AccountProcessor { get; set; }
    }
}
