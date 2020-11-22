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
        
        [Fact]
        public void GetTemperatureFahrenheit_Returns32For273Kelvin()
        {
            string jsonString = "{\"main\": {\"temp\":273}}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureFahrenheit();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("32℉", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTemperatureFahrenheit_ReturnTempNotFoundForIncorrectJObject()
        {
            string jsonString = "{\"main\": 273}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureFahrenheit();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("Temp not found", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetFeelsLikeTemperatureFahrenheit_Returns32For273Kelvin()
        {
            string jsonString = "{\"main\": {\"feels_like\":273}}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureFahrenheit();

            string result = getTempCelsius.GetFeelsLikeTemperature(jObject);
            Assert.Equal("32℉", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetFeelsLikeTemperatureFahrenheit_ReturnTempNotFoundForIncorrectJObject()
        {
            string jsonString = "{\"main\": 273}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureFahrenheit();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("Temp not found", result);
            Assert.NotNull(result);
        }
        
        [Fact]
        public void GetTemperatureCelsiusAndFahrenheit_Returns0And32For273Kelvin()
        {
            string jsonString = "{\"main\": {\"temp\":273}}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsiusAndFahrenheit();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("0℃ (32℉)", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTemperatureCelsiusAndFahrenheit_ReturnTempNotFoundForIncorrectJObject()
        {
            string jsonString = "{\"main\": 273}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsiusAndFahrenheit();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("Temp not found", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetFeelsLikeTemperatureCelsiusAndFahrenheit_Returns0And32For273Kelvin()
        {
            string jsonString = "{\"main\": {\"feels_like\":273}}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsiusAndFahrenheit();

            string result = getTempCelsius.GetFeelsLikeTemperature(jObject);
            Assert.Equal("0℃ (32℉)", result);
            Assert.NotNull(result);
        }

        [Fact]
        public void GetFeelsLikeTemperatureCelsiusAndFahrenheit_ReturnTempNotFoundForIncorrectJObject()
        {
            string jsonString = "{\"main\": 273}";
            var jObject = JObject.Parse(jsonString);

            var getTempCelsius = new GetTemperatureCelsiusAndFahrenheit();

            string result = getTempCelsius.GetTemperature(jObject);
            Assert.Equal("Temp not found", result);
            Assert.NotNull(result);
        }
    }
}
