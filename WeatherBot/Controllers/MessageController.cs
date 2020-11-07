using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using WeatherBot.Models;

namespace WeatherBot.Controllers
{
    public class MessageController : Controller
    {
        [HttpPost]
        [Route(@"api/message/update")]
        public async Task<OkResult> Update([FromBody]Update update)
        {
            if (update == null)
            {
                return Ok();
            }

            var commands = Bot.Commands;
            var message = update.Message;
            var client = await Bot.GetClient();

            var sdf = update.Message.Text;

            foreach (var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }
            
            return Ok();
        }
    }
}