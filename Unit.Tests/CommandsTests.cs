using WeatherBot.Models.Commands;
using Xunit;

namespace Unit.Tests
{
    public class CommandsTests
    {
        [Fact]
        public void StartCommand_DoesNotContainsWeatherString()
        {
            var startCommand = new StartCommand();

            var result = startCommand.Contains("/wether");

            Assert.False(result);
        }

        [Fact]
        public void StartCommand_ContainsStartString()
        {
            var startCommand = new StartCommand();

            var result = startCommand.Contains("/start");

            Assert.True(result);
        }

        [Fact]
        public void WeattherCommand_DoesNotContainsStartString()
        {
            var weatherCommand = new WeatherCommand();

            var result = weatherCommand.Contains("/start");

            Assert.False(result);
        }

        [Fact]
        public void WeatherCommand_ContainsWeatherString()
        {
            var weatherCommand = new WeatherCommand();

            var result = weatherCommand.Contains("/weather");

            Assert.True(result);
        }

        [Fact]
        public void WeatherCelsiusCommand_DoesNotContainsStartString()
        {
            var weathercelsiusCommand = new WeatherCelsiusCommand();

            var result = weathercelsiusCommand.Contains("/start");

            Assert.False(result);
        }

        [Fact]
        public void WeatherCelsiusCommand_ContainsWeathercelsiusString()
        {
            var weathercelsiusCommand = new WeatherCelsiusCommand();

            var result = weathercelsiusCommand.Contains("/weathercelsius");

            Assert.True(result);
        }

        [Fact]
        public void WeatherFahrenheitCommand_DoesNotContainsStartString()
        {
            var weathercelsiusCommand = new WeatherFahrenheitCommand();

            var result = weathercelsiusCommand.Contains("/start");

            Assert.False(result);
        }

        [Fact]
        public void WeatherFahrenheitCommand_ContainsWeathercelsiusString()
        {
            var weathercelsiusCommand = new WeatherFahrenheitCommand();

            var result = weathercelsiusCommand.Contains("/weatherfahrenheit");

            Assert.True(result);
        }
    }
}
