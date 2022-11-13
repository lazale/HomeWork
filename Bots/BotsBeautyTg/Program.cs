using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ConsoleApp1
{
    internal class Program
    {
        private static CancellationToken cancellationToken;

        static void Main(string[] args)
        {
            var client = new TelegramBotClient("5743172258:AAFAp0TskCZK8NwURic2jEbiDpplg8jNiK0");
            client.StartReceiving(Update, Error);
            Console.ReadLine();

        }
        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken arg3)
        {
            var message = update.Message;

            if (message.Text != null)
            {
                Console.WriteLine($"{message.Chat.FirstName} | {message.Text}" +
                    $" | date {message.Date}. ");
                if (message.Text.ToLower().Contains("start"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Привет. \nЯ тестовый бот. \nСейчас " + DateTime.Now + " МСК. \nНа данный момент я знаю только 2 слова \"Привет\" и \"Контакты\", напиши мне их.");
                    return;
                }

                else if (message.Text.ToLower().Contains("привет"))    //текст приходит, с любой буквы большой или маленькой, вкл в себя Contains
                {
                    Message message1 = await botClient.SendPhotoAsync(chatId: message.Chat.Id,
                       photo: "https://sun9-81.userapi.com/impg/jARaM9ZIlzXssNBAuS_ZVg7OP4OdgxTYIrp1aQ/qyHTvB5eBpc.jpg?size=1080x1080&quality=95&sign=a474f2a2a8efd2a677d7394e4f67e21e&type=album",
                       caption: "Привет🙌🏼 \nЯ бот beauty пространства \"Руки нам\" 🤍 \nЯ ищу подружек, которым смогу доверить свои секреты в виде самых горящих скидок на услуги " +
                     "в beauty пространство \"Руки нам\" г.Казань🌸 \nТеперь, когда ты надумаешь сделать маникюр, педикюр или бровки, просто загляни ко мне в гости и я тебе всё расскажу😘");


                    Message message2;
                    using (var stream = System.IO.File.OpenRead("C:/users/Afif07/Documents/C#/WORK/bots/ConsoleApp1/path/213123.mp4"))
                    {
                        message2 = await botClient.SendVideoNoteAsync(
                            chatId: message.Chat.Id,
                            videoNote: stream,
                            duration: 47,
                            length: 360, // value of width/height
                                cancellationToken: cancellationToken);
                        return;
                    }


                }

                else if (message.Text.ToLower().Contains("контакты"))
                {
                    Message message_tel = await botClient.SendContactAsync(
    chatId: message.Chat.Id,
    phoneNumber: "+79196370606",
    firstName: "Руки нам",
    vCard: "BEGIN:VCARD\n" +
           "VERSION:3.0\n" +
           "N:Solo;Han\n" +
           "TEL;TYPE=voice,work,pref:+79196370606\n" +
           "EMAIL:hansolo@mfalcon.com\n" +
           "END:VCARD",
    cancellationToken: cancellationToken);
                    Message message_kontakty = await botClient.SendVenueAsync(
      chatId: message.Chat.Id,
      latitude: 55.82326,
      longitude: 49.07437,
      title: "Руки нам",
      address: "Казань, ул. Серова 48 к2",
      cancellationToken: cancellationToken);


                    //await botClient.SendTextMessageAsync(message.Chat.Id, "krjk saadsdasd");

                    return;
                }


            }
            if (message.Photo != null)
            {
                await botClient.SendTextMessageAsync(message.Chat.Id, "Нормальное фото, но лучше отправь документом.");
                return;
            }
        }
        private static Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }


    }
}
