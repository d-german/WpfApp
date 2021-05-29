﻿using System;

namespace WpfApp
{
    public class WeatherService : IWeatherService
    {
        public WeatherData FetchWeatherData()
        {
            var rng = new Random();
            return new WeatherData
            {
                Zipcode = "64083",
                Temperature = rng.Next(-10, 110),
                Humidity = rng.Next(0, 100),
                Precipitation = rng.Next(0, 100),
                UvIndex = rng.Next(0, 10),
                DateTime = DateTime.Now
            };
        }
    }
}
