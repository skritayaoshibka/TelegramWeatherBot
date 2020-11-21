using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using WeatherBot.Models.Commands;

namespace WeatherBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandsList;
        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> GetClient()
        {
            if (client != null)
            {
                return client;
            }

            commandsList = new List<Command>();
            commandsList.Add(new StartCommand());
            commandsList.Add(new WeatherCelsiusCommand());
            commandsList.Add(new WeatherFahrenheitCommand());
            commandsList.Add(new WeatherCommand());
            
            client = new TelegramBotClient(BotSettings.Key);
            var hook = string.Format(BotSettings.Url, "/api/message/update");
            await client.SetWebhookAsync(hook);

            return client;
        }
    }
}