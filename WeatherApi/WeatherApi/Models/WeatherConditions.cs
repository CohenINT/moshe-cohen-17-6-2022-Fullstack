using System;
using System.ComponentModel.DataAnnotations;

namespace WeatherApi.Models
{

    public class LocalSourceModel
    {
      
        public Int32 Id { set; get; }
        public string Name { get; set; }
        public string WeatherCode { set; get; }
    }

    public class MetricModel
    {
      
        public string Id { set; get; }
        public string Unit { set; get; }
        public double Value { set; get; }
        public Int32 UnitType { set; get; }

    }

    public class ImperialModel
    {
       
        public string Id { set; get; }
        public double Value { set; get; }
        public string Unit { set; get; }
        public Int32 UnitType { set; get; }

    }

    public class TemperatureModel
    {
        
        public string Id { set; get; }
        public ImperialModel Imperial { set; get; }
        public MetricModel Metric { set; get; }

    }

    public class DirectionModel
    {
       
        public string Id { set; get; }
        public Int32 Degrees { set; get; }
        public string English { set; get; }
        public string Localized { set; get; }
    }

    public class WindModel
    {
        
        public string Id { set; get; }
        public DirectionModel Direction { set; get; }
        public string Speed { set; get; }
    }
    public class WindGustModel
    {
        
        public string Id { set; get; }
        public string Speed { set; get; }
    }

    public class PressureTendencyModel
    {
        
        public string Id { set; get; }
        public string LocalizedText { set; get; }
        public string Code { set; get; }
    }

    public class WeatherConditions
    {

        
        [Key]
        public string Id { set; get; }
        public string LocalObservationDateTime { set; get; }
        public Int64 EpochTime { set; get; }
        public string WeatherText { set; get; }
        public Int32 WeatherIcon { set; get; }
        public LocalSourceModel LocalSource { set; get; }
        public bool IsDayTime { set; get; }
        public TemperatureModel Temperature { set; get; }

        public string RealFeelTemperature { set; get; }
        public string RealFeelTemperatureShade { set; get; }
        public Int32 RelativeHumidity { set; get; }
        public string DewPoint { set; get; }
        public WindModel Wind { set; get; }
        public WindGustModel WindGust { set; get; }
        public Int32 UVIndex { set; get; }
        public string UVIndexText { set; get; }
        public string Visibility { set; get; }

        public string ObstructionsToVisibility { set; get; }
        public Int32 CloudCover { set; get; }
        public string Ceiling { set; get; }
        public string Pressure { set; get; }
        public PressureTendencyModel PressureTendency { set; get; }
        public string Past24HourTemperatureDeparture { set; get; }
        public string ApparentTemperature { set; get; }
        public string WindChillTemperature { set; get; }
        public string WetBulbTemperature { set; get; }

    }
}
