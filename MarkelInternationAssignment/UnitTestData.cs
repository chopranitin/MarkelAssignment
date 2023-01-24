using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;

namespace MarkelInternationAssignment
{
    public class UnitTestData:IGetInsuranceData
    {
        private List<Claim> _claims;
        private List<ClaimType> _claimTypes;
        private List<Company> _company;
        public UnitTestData()
        {
            _claims = new List<Claim>();
             Claim cl = new Claim{ AssuredName = "unittest",
             UCR = "unittestucr",
             CompanyId = 1,
             ClaimDate = DateTime.Now,
             Closed = 0,
             LossDate  = DateTime.Now,
             IncurredLoss = 20
             };
            _claims.Add(cl);

        }
        public List<Claim> GetClaims()
        {
            return this._claims;
        }

        public List<ClaimType> GetClaimType()
        {
            return this._claimTypes;
        }

        public List<Company> GetCompanies()
        {
            return this._company;
        }

        public void updateClaim(int id, Claim claim)
        {

        }


    }
}
