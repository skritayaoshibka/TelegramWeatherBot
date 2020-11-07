using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherBot.Models.Commands
{
    public class StartCommand : Command
    {
        protected override string Name => "/start";
        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            
            await client.SendTextMessageAsync(chatId, "Hi, I'm weatherBot", replyToMessageId: messageId);
        }
    }
}