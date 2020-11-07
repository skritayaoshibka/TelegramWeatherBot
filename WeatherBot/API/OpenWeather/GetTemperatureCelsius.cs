﻿using Newtonsoft.Json.Linq;

namespace WeatherBot.API.OpenWeather
{
    public class GetTemperatureCelsius : IGetTemperatureBehavior
    {
        public string GetTemperature(JObject weatherData)
        {
            string feelsLikeTemperature = ((int)weatherData["main"]["temp"] - 273).ToString() + "℃";
            return feelsLikeTemperature;
        }

        public string GetFeelsLikeTemperature(JObject weatherData)
        {
            string temperature = ((int)weatherData["main"]["feels_like"] - 273).ToString() + "℃";
            return temperature;
        }

        
    }
}