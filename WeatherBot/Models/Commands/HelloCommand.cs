using Telegram.Bot;
using Telegram.Bot.Types;

namespace WeatherBot.Models.Commands
{
    public class HelloCommand : Command
    {
        protected override string Name => "/hello";
        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            
            await client.SendTextMessageAsync(chatId, "Hello world!", replyToMessageId: messageId);
        }
    }
}