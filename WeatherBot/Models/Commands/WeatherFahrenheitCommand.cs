using Telegram.Bot;
using Telegram.Bot.Types;
using WeatherBot.API.OpenWeather;

namespace WeatherBot.Models.Commands
{
    public class WeatherFahrenheitCommand : Command
    {
        protected override string Name => "/weatherfahrenheit";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            string cityName = message.Text.Substring(this.Name.Length);
            OpenWeatherAPI weatherInfo = new OpenWeatherAPI();

            bool weatherDataLoadStatus = weatherInfo.LoadWeatherData(cityName);
            if (!weatherDataLoadStatus)
            {
                await client.SendTextMessageAsync(chatId,
                                                  "I can't find information for your city. " +
                                                  "Maybe you entered the city name incorrectly. " +
                                                  "Command example: \"/weatherfahrenheit London\"",
                                                  replyToMessageId: messageId);
                return;
            }

            weatherInfo.SetGetTemparatureBehaviour(new GetTemperatureFahrenheit());

            string temperature = weatherInfo.PerformGetTemparature();
            string feelsLikeTemperature = weatherInfo.PerformGetFeelsLikeTemparature();
            string humidity = weatherInfo.GetHumidity();
            string weatherDescription = weatherInfo.GetWeatherDescription();

            string response = $"City: {cityName}\n" +
                              $"Temperature: {temperature} \n" +
                              $"Feels like: {feelsLikeTemperature} \n" +
                              $"Humidity: {humidity}% \n" +
                              $"Description: {weatherDescription}";


            await client.SendTextMessageAsync(chatId, response, replyToMessageId: messageId);
        }
    }
}
