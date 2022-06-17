namespace WeatherApi.Models
{
    public class AutocompleteResponse
    {
        public class CountryModel
        {
            public string ID { set; get; } //IL 
            public string LocalizedName { set; get; } // ישראל
        }

        public class AdministrativeAreaModel
        {
            public string ID { set; get; }//HA
            public string LocalizedName { set; get; } //מחוז חיפה
        }

        public int Version { get; set; }
        public string Key { set; get; }
        public string Type { set; get; } // City
        public int Rank { set; get; } //31
        public string LocalizedName { set; get; }
        public CountryModel Country { set; get; }
        public AdministrativeAreaModel AdministrativeArea { set; get; }

    }
}
