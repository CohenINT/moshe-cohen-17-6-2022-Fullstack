using System;

namespace WeatherApi.Models
{
    public class WeatherConditions
    {

        public class LocalSourceModel
        {
            public Int32 Id { set; get; }
            public string Name { get; set; }
            public string WeatherCode { set; get; }
        }

        public class MetricModel
        {
            public string Unit { set; get; }
            public double Value { set; get; }
            public Int32 UnitType { set; get; }

        }

        public class ImperialModel
        {
            public double Value { set; get; }
            public string Unit { set; get; }
            public Int32 UnitType { set; get; }

        }

        public class TemperatureModel
        {
            public ImperialModel Imperial { set; get; }
            public MetricModel Metric { set; get; }

        }

        public class DirectionModel
        {
            public Int32 Degrees { set; get; }
            public string English { set; get; }
            public string Localized { set; get; }
        }

        public class WindModel
        {
            public DirectionModel Direction { set; get; }
            public object Speed { set; get; }
        }
        public class WindGustModel
        {
            public object Speed { set; get; }
        }

        public class PressureTendencyModel
        {
            public string LocalizedText { set; get; }
            public string Code { set; get; }
        }

        public string LocalObservationDateTime { set; get; }
        public Int64 EpochTime { set; get; }
        public string WeatherText { set; get; }
        public Int32 WeatherIcon { set; get; }
        public LocalSourceModel LocalSource { set; get; }
        public bool IsDayTime { set; get; }
        public TemperatureModel Temperature { set; get; }

        public object RealFeelTemperature { set; get; }
        public object RealFeelTemperatureShade { set; get; }
        public Int32 RelativeHumidity { set; get; }
        public object DewPoint { set; get; }
        public WindModel Wind { set; get; }
        public WindGustModel WindGust { set; get; }
        public Int32 UVIndex { set; get; }
        public string UVIndexText { set; get; }
        public object Visibility { set; get; }

        public string ObstructionsToVisibility { set; get; }
        public Int32 CloudCover { set; get; }
        public object Ceiling { set; get; }
        public object Pressure { set; get; }
        public PressureTendencyModel PressureTendency { set; get; }
        public object Past24HourTemperatureDeparture { set; get; }
        public object ApparentTemperature { set; get; }
        public object WindChillTemperature { set; get; }
        public object WetBulbTemperature { set; get; }

    }
}
