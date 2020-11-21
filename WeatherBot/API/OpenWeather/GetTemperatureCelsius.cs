using Newtonsoft.Json.Linq;
using System;

namespace WeatherBot.API.OpenWeather
{
    public class GetTemperatureCelsius : IGetTemperatureBehavior
    {
        public string GetTemperature(JObject weatherData)
        {
            try
            {
                string temperature = ((int)weatherData["main"]["temp"] - 273).ToString() + "℃";
                
                return temperature;
            }
            catch(Exception ex)
            {
                return "Temp not found";
            }            
        }

        public string GetFeelsLikeTemperature(JObject weatherData)
        {
            try
            {
                string feelsLikeTemperature = ((int)weatherData["main"]["feels_like"] - 273).ToString() + "℃";

                return feelsLikeTemperature;
            }
            catch (Exception ex)
            {
                return "Temp not found";
            } 
        }


    }
}
