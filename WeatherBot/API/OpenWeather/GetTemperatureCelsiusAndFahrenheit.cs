using Newtonsoft.Json.Linq;
using System;

namespace WeatherBot.API.OpenWeather
{
    public class GetTemperatureCelsiusAndFahrenheit : IGetTemperatureBehavior
    {
        public string GetTemperature(JObject weatherData)
        {
            try
            {
                string temperatureC = ((int)weatherData["main"]["temp"] - 273).ToString() + "℃";
                string temperatureF = Math.Round(((int)weatherData["main"]["temp"] - 273) * 1.8 + 32).ToString() + "℉";

                return temperatureC + " (" + temperatureF + ")";
            }
            catch (Exception ex)
            {
                return "Temp not found";
            }
        }

        public string GetFeelsLikeTemperature(JObject weatherData)
        {
            try
            {
                string feelsLikeTemperatureC = ((int)weatherData["main"]["feels_like"] - 273).ToString() + "℃";
                string feelsLikeTemperatureF = Math.Round(((int)weatherData["main"]["feels_like"] - 273) * 1.8 + 32).ToString() + "℉";

                return feelsLikeTemperatureC + " (" + feelsLikeTemperatureF + ")";
            }
            catch (Exception ex)
            {
                return "Temp not found";
            }
        }
    }
}
