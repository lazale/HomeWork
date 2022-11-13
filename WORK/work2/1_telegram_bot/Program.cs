using System;
using Telegram.Bot;


namespace _1_telegram_bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var bot = new TelegramBotClient("5743172258:AAFAp0TskCZK8NwURic2jEbiDpplg8jNiK0");
            bot.StartReceiving();
            Console.ReadLine();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
