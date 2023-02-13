
using Microsoft.AspNetCore.Mvc;
using CountryService.CountryDemo.Clients;

namespace src.CountryService.CountryDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ILogger<CountryController> _logger;
        private readonly ICountryCodeClient _countryCodeClient;

        public CountryController(ILogger<CountryController> logger,ICountryCodeClient countryCodeClient)
        {
            _logger = logger;
            _countryCodeClient = countryCodeClient;
        }

     
        [HttpGet("{code}")]
        public async Task<IActionResult> Get(string code)
        {
            var result=await _countryCodeClient.GetAll(code);
            return result is not null? Ok(result):NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> GetCountryCode()
        {
            var result = await _countryCodeClient.GetCountryCode();
            return result is not null ? Ok(result) : NotFound();
        }

    }
}