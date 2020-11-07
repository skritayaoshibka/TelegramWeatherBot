using Newtonsoft.Json.Linq;
using System;

namespace WeatherBot.API.OpenWeather
{
    public class GetTemperatureFahrenheit : IGetTemperatureBehavior
    {
        public string GetTemperature(JObject weatherData)
        {
            string feelsLikeTemperature = Math.Round((double)weatherData["main"]["temp"] * (9 / 5) - 459.67).ToString() + "℉";
            return feelsLikeTemperature;
        }

        public string GetFeelsLikeTemperature(JObject weatherData)
        {
            string temperature = Math.Round((double)weatherData["main"]["feels_like"] * (9/5) - 459.67).ToString() + "℉";
            return temperature;
        }
    }
}
