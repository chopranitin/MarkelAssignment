using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.EntityFrameworkCore;

public class GetInsuranceDataEF : IGetInsuranceData
{
    private List<Claim> _claims;
    private List<ClaimType> _claimTypes;
    private List<Company> _company;
    private dynamic json;
    private IConfiguration config;
    public GetInsuranceDataEF(IConfiguration _configuration)
    {
        config = _configuration;
    }
            
    public List<Claim> GetClaims()
    {
        var db = new Claimsdbcontext(config);
        var cm = db.claim.OrderBy(b => b.CompanyId);
        this._claims = cm.ToList<Claim>();
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
        var db = new Claimsdbcontext(config);
        db.claim.Where(e => e.CompanyId == id).ExecuteUpdate(x => 
        x.SetProperty(x => x.UCR ,claim.UCR).
        SetProperty(x => x.AssuredName, claim.AssuredName)
        );
          
    }
    
}