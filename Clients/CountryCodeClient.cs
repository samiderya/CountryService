using Newtonsoft.Json;
using CountryService.CountryDemo.Models.Dtos;

namespace CountryService.CountryDemo.Clients
{
    public class CountryCodeClient: ICountryCodeClient
    {
        private readonly HttpClient _httpClient;
  
        public CountryCodeClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CountryDto?> GetAll(string countryCode)
        {
            var responseString = await _httpClient.GetStringAsync($"wpgp?iso3={countryCode}");
            var str1= (responseString.Trim().Remove(0,8));
            var  str2 = str1.Remove(str1.Length - 1, 1);
            var _Resp = JsonConvert.DeserializeObject<List<CountryDto>>(str2);
            return _Resp.FirstOrDefault();
        }
        public async Task<List<CountryCodeDto>> GetCountryCode()
        {
            var responseString = await _httpClient.GetStringAsync($"wpgp");
            var str1 = (responseString.Trim().Remove(0, 8));
            var str2 = str1.Remove(str1.Length - 1, 1);

            var _Resp = JsonConvert.DeserializeObject<List<CountryCodeDto>>(str2);
            return _Resp;
        }
    
    
    }
}
