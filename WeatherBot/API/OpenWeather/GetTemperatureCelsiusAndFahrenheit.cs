using Newtonsoft.Json.Linq;
using System;

namespace WeatherBot.API.OpenWeather
{
    public class GetTemperatureCelsiusAndFahrenheit : IGetTemperatureBehavior
    {
       public string GetTemperature(JObject weatherData)
        {
            string feelsLikeTemperatureC = ((int)weatherData["main"]["temp"] - 273).ToString() + "℃";
            string feelsLikeTemperatureF = Math.Round((double)weatherData["main"]["temp"] * (9 / 5) - 459.67).ToString() + "℉";

            return feelsLikeTemperatureC + " (" + feelsLikeTemperatureF + ")";
        }

         public string GetFeelsLikeTemperature(JObject weatherData)
        {
            string feelsLikeTemperatureC = ((int)weatherData["main"]["feels_like"] - 273).ToString() + "℃";
            string feelsLikeTemperatureF = Math.Round((double)weatherData["main"]["feels_like"] * (9 / 5) - 459.67).ToString() + "℉";

            return feelsLikeTemperatureC + " (" + feelsLikeTemperatureF + ")";
        }
    }
}
