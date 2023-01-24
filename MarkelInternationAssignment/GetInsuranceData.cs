using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GetInsuranceData : IGetInsuranceData
{
    private List<Claim> _claims;
    private List<ClaimType> _claimTypes;
    private List<Company> _company;
    private dynamic json;

    public GetInsuranceData()
    {
        using (StreamReader file = File.OpenText("insurancedata.json"))
     {
          
            json = JToken.Parse(file.ReadToEnd());

            this._claims= JsonConvert.DeserializeObject<List<Claim>>(json.Claim.ToString());
            this._claimTypes= JsonConvert.DeserializeObject<List<ClaimType>>(JsonConvert.SerializeObject(json.ClaimType));
            this._company = JsonConvert.DeserializeObject<List<Company>>(JsonConvert.SerializeObject(json.Company));

        }
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
        List<Claim> claims = this.GetClaims();
        
        Claim existingClaim = claims.Find(item => item.CompanyId == id);

        int index = claims.IndexOf(existingClaim);

        claims[index] = claim;
        int i = 0;
        claims.ForEach(delegate (Claim cl)
        {

            json.Claim[i] = JToken.FromObject(cl);
            i++;
        });

        File.WriteAllText("insurancedata.json",json.ToString());

    }
    
}