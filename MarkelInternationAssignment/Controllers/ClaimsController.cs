using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarkelInternationAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimsController : ControllerBase
    {
        private readonly ILogger<ClaimsController> _logger;
        private IGetInsuranceData _insurance;

        public ClaimsController(ILogger<ClaimsController> logger, IGetInsuranceData insurance)
        {
            _logger = logger;
            _insurance = insurance;
        }
        // GET: api/<ClaimsController>
        [HttpGet]
       
        public IEnumerable<Claim> Get()
        {
            return _insurance.GetClaims();
            
        }

        // GET api/<ClaimsController>/5
        [HttpGet("{id}")]
        public IEnumerable<Claim> Get(int id)
        {
           List<Claim> claims = _insurance.GetClaims();
            claims = claims.FindAll(item => item.CompanyId == id);           
            return claims;

        }

        // POST api/<ClaimsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClaimsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Claim value)
        {
            //_insurance.updateClaim(id, value);
        }

        // DELETE api/<ClaimsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
