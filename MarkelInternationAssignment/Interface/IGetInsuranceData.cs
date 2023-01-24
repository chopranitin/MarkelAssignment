using MarkelInternationAssignment.Model;

namespace MarkelInternationAssignment.Interface
{
    public interface IGetInsuranceData
    {
     
        public List<Claim> GetClaims();

        public List<Company> GetCompanies();

        public List<ClaimType> GetClaimType();

        public void updateClaim(int id, Claim claim);
    }
}
