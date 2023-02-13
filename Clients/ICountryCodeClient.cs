
using CountryService.CountryDemo.Models.Dtos;

namespace CountryService.CountryDemo.Clients
{
    public interface ICountryCodeClient
    {
        Task<CountryDto> GetAll(string countryCode);
        Task<List<CountryCodeDto>> GetCountryCode();
    }
}
