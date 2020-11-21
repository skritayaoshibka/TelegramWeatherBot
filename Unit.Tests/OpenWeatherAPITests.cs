using Newtonsoft.Json.Linq;
using WeatherBot.API.OpenWeather;
using Xunit;

namespace Unit.Tests
{
    public class OpenWeatherAPITests
    {
        [Fact]
        public void GetTemperatureCelsius_Returns0For273Kelvin()
        {
            string jsonString = "{\"main\": {\"temp\":273}}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsius();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("0℃", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTemperatureCelsius_ReturnTempNotFoundForIncorrectJObject()
        {
            string jsonString = "{\"main\": 273}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsius();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("Temp not found", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetFeelsLikeTemperatureCelsius_Returns0For273Kelvin()
        {
            string jsonString = "{\"main\": {\"feels_like\":273}}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsius();

            string result = getTempCelsius.GetFeelsLikeTemperature(jObject);
            Assert.Equal("0℃", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetFeelsLikeTemperatureCelsius_ReturnTempNotFoundForIncorrectJObject()
        {
            string jsonString = "{\"main\": 273}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsius();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("Temp not found", result);
            Assert.NotNull(result);
        }
    }
}
