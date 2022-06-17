using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
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
        private string CurrentConditionsEndpoint { set; get; } = "/currentconditions/v1/{{1}}";
        private ILogger<WeatherController> log { set; get; }
        public WeatherController(ILogger<WeatherController> logger)
        {
            this.client = new HttpClient();
            this.log = logger;
        }



        [ProducesResponseType(typeof(List<AutocompleteResponse>), statusCode: 200)]
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
        public async Task<List<WeatherConditions>> GetCurrentWeather([FromQuery] string locationkey, [FromQuery] string apikey, [FromQuery] string language, [FromQuery] bool details = false)
        {
            var url = $"{this.CurrentConditionsEndpoint.Replace("{{1}}", locationkey)}?apikey={apikey}&language={language}&details={details}";
            var dataResponse = await this.client.GetAsync(url);
            if (!dataResponse.IsSuccessStatusCode)
            {
                this.log.LogError($"Issue with fetching the weather conditions from external API.  location key - {locationkey} , apikey - {apikey} , lang = {language} , details - {details}");
                return null;
            }
            return null;

            //TODO: 


        }
        [HttpGet]
        public async Task<string> Test()
        {
            using (var db = new WeatherDbContext())
            {
                try
                {
                    var record = new WeatherConditions() {Id = Guid.NewGuid().ToString(), IsDayTime = true };
                    db.WeatherRecords.Add(record);

                    var res = await db.SaveChangesAsync();
                    return res.ToString();

                }
                catch (System.Exception ex)
                {


                }
                return "";

            }
        }


    }
}
