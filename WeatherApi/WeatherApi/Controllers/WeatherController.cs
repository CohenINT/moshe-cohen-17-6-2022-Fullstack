using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeatherController : Controller
    {
        private HttpClient client { set; get; }
        private string BaseUrl { set; get; } = "http://dataservice.accuweather.com";
        private string AutocompleteEndpoint { set; get; } = "/locations/v1/cities/autocomplete";
        private ILogger<WeatherController> log { set; get; }
        public WeatherController(ILogger<WeatherController> logger)
        {
            this.client = new HttpClient();
            this.log = logger;
        }



        [ProducesResponseType(typeof(List<AutocompleteResponse>, 200))]
        [HttpGet]
        public async Task<List<AutocompleteResponse>> Search([FromQuery] string apikey, [FromQuery] string q, [FromQuery] string language)
        {
            var httpResult = await this.client.GetAsync($"{this.BaseUrl}{AutocompleteEndpoint}?apikey={apikey}&q={q}&language={language}");
            if (!httpResult.IsSuccessStatusCode)
            {
                //TODO: log error
                return null;
            }


            var ResultDataString = await httpResult.Content.ReadAsStringAsync();
            var resultData = JsonConvert.DeserializeObject<List<AutocompleteResponse>>(ResultDataString);
            return resultData;

        }


        [HttpGet]
        public async Task<> GetCurrentWeather

        [HttpGet]
        public string Test()
        {
            return "llol";
        }


    }
}
