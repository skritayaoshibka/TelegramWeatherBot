using Newtonsoft.Json.Linq;

namespace WeatherBot.API.OpenWeather
{
    public interface IGetTemperatureBehavior
    {
        public string GetTemperature(JObject weatherData);
        public string GetFeelsLikeTemperature(JObject weatherData);
    }
}
