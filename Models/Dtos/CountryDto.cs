using Newtonsoft.Json;

namespace CountryService.CountryDemo.Models.Dtos
{
    public class CountryDto
    {

        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("iso3")]
        public string CountryCode { get; set; }

    }
    public class CountryCodeDto
    {

        [JsonProperty("iso3")]
        public string CountryCode { get; set; }
    }

}