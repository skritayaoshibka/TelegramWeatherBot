using Newtonsoft.Json.Linq;
using System;

namespace WeatherBot.API.OpenWeather
{
    public class GetTemperatureFahrenheit : IGetTemperatureBehavior
    {
        public string GetTemperature(JObject weatherData)
        {
            string temperature = Math.Round(((int)weatherData["main"]["temp"]  - 273) * 1.8 + 32).ToString() + "℉";
            
            return temperature;
        }

        public string GetFeelsLikeTemperature(JObject weatherData)
        {
            string feelsLikeTemperature = Math.Round(((int)weatherData["main"]["feels_like"] - 273) * 1.8 + 32).ToString() + "℉";
            
            return feelsLikeTemperature;
        }
    }
}
