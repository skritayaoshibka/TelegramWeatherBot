using Newtonsoft.Json.Linq;
using System;

namespace WeatherBot.API.OpenWeather
{
    public class GetTemperatureFahrenheit : IGetTemperatureBehavior
    {
        public string GetTemperature(JObject weatherData)
        {
            try
            {
                string temperature = Math.Round(((int)weatherData["main"]["temp"] - 273) * 1.8 + 32).ToString() + "℉";

                return temperature;
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
                string feelsLikeTemperature = Math.Round(((int)weatherData["main"]["feels_like"] - 273) * 1.8 + 32).ToString() + "℉";

                return feelsLikeTemperature;
            }
            catch (Exception ex)
            {
                return "Temp not found";
            }
        }
    }
}
