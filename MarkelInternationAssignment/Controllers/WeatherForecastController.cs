using Microsoft.AspNetCore.Mvc;
using MarkelInternationAssignment.Interface;
using MarkelInternationAssignment.Model;

namespace MarkelInternationAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private IGetInsuranceData _insurance;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IGetInsuranceData insurance)
        {
            _logger = logger;
            _insurance = insurance;
        }

        [HttpGet]
        public IEnumerable<Claim> Get()
        {
            return _insurance.GetClaims()
            .ToArray();
        }
    }
}