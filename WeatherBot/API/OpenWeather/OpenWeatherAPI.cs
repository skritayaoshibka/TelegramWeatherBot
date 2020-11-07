using Newtonsoft.Json.Linq;
using System.Net;
using System;
using WeatherBot.Models;

namespace WeatherBot.API.OpenWeather
{
    public class OpenWeatherAPI
    {
        JObject WeatherDataJsonObject;
        IGetTemperatureBehavior GetTemperatureBehavior;

        public bool LoadWeatherData(string cityName)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    string url = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={OpenWeatherAPISettings.Key}";
                    var jsonString = webClient.DownloadString(url);
                    WeatherDataJsonObject = JObject.Parse(jsonString);
                }
            }
            catch(Exception exception)
            {
                return false;
            }

            return true;
        }

        public void SetGetTemparatureBehaviour(IGetTemperatureBehavior getTemperatureBehavior)
        {
            GetTemperatureBehavior = getTemperatureBehavior;
        }

        public string PerformGetTemparature()
        {
            if (WeatherDataJsonObject != null)
            {
                return GetTemperatureBehavior.GetTemperature(WeatherDataJsonObject);
            }

            return null;
        }

        public string PerformGetFeelsLikeTemparature()
        {
            if (WeatherDataJsonObject != null)
            {
                return GetTemperatureBehavior.GetFeelsLikeTemperature(WeatherDataJsonObject);
            }

            return null;
        }

        public string GetHumidity()
        {
            if(WeatherDataJsonObject != null)
            {
                return (string)WeatherDataJsonObject["main"]["humidity"];
            }

            return null;
        }

        public string GetWeatherDescription()
        {
            if (WeatherDataJsonObject != null)
            {
                return (string)WeatherDataJsonObject["weather"][0]["main"];
            }

            return null;
        }
    }
}
