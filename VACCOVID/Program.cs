using System;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Extensions.Polling;

namespace VACCOVID
{
    class Program
    {
        static void Main(string[] args)
        {
            VACCOVID VACCOVID = new VACCOVID();
            VACCOVID.Start();
            Console.ReadKey();


        }
    }
}
