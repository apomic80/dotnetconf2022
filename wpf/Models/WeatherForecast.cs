using System;
using System.Runtime.Serialization;

namespace wpf.Models
{
    [DataContract]
    public class WeatherForecast
    {
        [DataMember]
        public string Date { get; set; }

        [DataMember]
        public int TemperatureC { get; set; }

        [DataMember]
        public string Summary { get; set; }

        [IgnoreDataMember]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
