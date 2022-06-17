namespace WeatherApi.Models
{
    public class AutocompleteRequest
    {
        public string RequestID { get; set; }
        public string ApiToken { set; get; }
        public string QuerySearch { set; get; }
        public string Language { set; get; }

    }
}
