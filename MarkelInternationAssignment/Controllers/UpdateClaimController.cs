using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarkelInternationAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateClaimController : ControllerBase
    {
        private readonly ILogger<UpdateClaimController> _logger;
        private IGetInsuranceData _insurance;

        public UpdateClaimController(ILogger<UpdateClaimController> logger, IGetInsuranceData insurance)
        {
            _logger = logger;
            _insurance = insurance;
        }

        // GET: api/<UpdateClaimController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UpdateClaimController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UpdateClaimController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UpdateClaimController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Claim value)
        {
            _insurance.updateClaim(id, value);
        }

        // DELETE api/<UpdateClaimController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
