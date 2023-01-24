using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarkelInternationAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<ClaimsController> _logger;
        private IGetInsuranceData _insurance;

        public CompanyController(ILogger<ClaimsController> logger, IGetInsuranceData insurance)
        {
            _logger = logger;
            _insurance = insurance;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public Company Get(int id)
        {
            List<Company> cmpList = _insurance.GetCompanies();
            Company cmp = cmpList.Find(item => item.id == id);
            if (cmp == null)
            {
                cmp = new Company();
            }
            return cmp;



        }

        // POST api/<CompanyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
