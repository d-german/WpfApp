using System;

namespace WpfApp
{
    public class WeatherData
    {
        private string? _zipcode;

        public string? Zipcode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public DateTime? DateTime { get; set; }
        public double? Temperature { get; set; }
        public double? Precipitation { get; set; }
        public double? Humidity { get; set; }
        public int? UvIndex { get; set; }
    }
}
