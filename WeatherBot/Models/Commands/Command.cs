using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherBot.Models.Commands
{
    public abstract class Command
    {
        protected abstract string Name { get; }

        public abstract void Execute(Message message, TelegramBotClient client);

        public bool Contains(string command)
        {
            return command.Contains(this.Name);
        }
    }
}