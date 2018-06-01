using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using System.Text.RegularExpressions;

namespace TelegramBot
{
    class Program
    {
        private static readonly ITelegramBotClient Bot = new TelegramBotClient("YOUR_API_KEY");

        

        static void Main(string [] args){
            Bot.OnMessage += Bot_OnMessage;
            Bot.OnMessageEdited += Bot_OnMessage;
            Console.WriteLine("\n___________________________________\nWe are active!\n___________________________________\n");

            Bot.StartReceiving();

            Console.ReadLine();
            Bot.StopReceiving();
    }

        


        ///APPLICATION
        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            String msg = e.Message.Text.ToLower();
            msg = RemoveSpecialCharacters(msg);
            Console.WriteLine("\n___________________________________\n\nProcessing..\n>Chat session ID: " + e.Message.Chat.Id + "\n___________________________________\n");

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.TextMessage)
            {
                ////Normal chatting
                if (msg == "hi" || msg == "hello" || msg == "heya" || msg == "hey")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Hello there " + e.Message.Chat.FirstName + "!");
                }
                else if (msg == "bye" || msg == "cheers" || msg == "seeya")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "See you!");
                }
                else if (msg == "howareyou" || msg == "whatsup" || msg == "sup")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "I'm fine, thanks! \nHow are you?");
                }
                else if (msg == "ok" || msg == "okay" || msg == "sure" || msg == "nope" || msg == "no" || msg == "yeah" || msg == "yes")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "If you say so!");
                }
                else if (msg == "whoareyou")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "I'm ThatOneBot, Better known as @SjorsHisBot! \nWho are you?");
                }
                else if (msg == "areyouabot")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "I am not, \n\n...\n\nUnless you meant hot?<3");
                }
                else if (msg == "good" || msg == "imgood" || msg == "awesome" || msg == "great" || msg == "imgreat" || msg == "awesome" || msg == "oustranding" || msg == "amazing")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Heck yeah!");
                }
                else if (msg == "thatshorrible" || msg == "eww" || msg == "blegh" || msg == "thatsucks" || msg == "ugh" || msg == "sigh" || msg == "awful")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "*Sigh*");
                }


                ////If known people
                else if (msg == "imspidey")
                {
                    if (e.Message.Chat.Username == "HiImSpidey")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Nice to see you!");
                    }
                    else if (e.Message.Chat.Username == "Sjooooors")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "You're Sjors you silly!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "You're not him!");
                    }
                }
                else if (msg == "immitchell")
                {
                    if (e.Message.Chat.Username == "N00B_C00K1E")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Woah it's you!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Ok cool.");
                    }
                }
                else if (msg == "imsjors")
                {
                    if (e.Message.Chat.Username == "Sjooooors")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "I greet you, Master!");
                    }
                    else if (e.Message.Chat.FirstName == "Sjors")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "You're not the Sjors I love!");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "No you're not.\nYou're " + e.Message.Chat.Username + "!");
                    }
                }

                ////Insulting
                else if (msg == "fuckyou" || msg == "nigger" || msg == "faggot" || msg == "cunt" || msg == "loser" || msg == "cock")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "nou");
                }

                ///MemeReactions
                else if (msg == "objection")
                {
                    if (e.Message.Chat.Username == "DaSuperCon")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Yes, What's wrong sir?");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Overruled.");
                    }
                }
                else if (msg == "wwwline")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "That's called an url.");
                }

                ////WhoIsCreator?
                else if (msg == "whomadeyou" || e.Message.Text == "/credits" || msg == "whoisyourcreator")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "@Sjooooors made me in C#,\nWith a little help of @N00B_C00K1E\n\nYou can subscribe to Sjors on Youtube at www.youtube.com/c/Sjooooors!");
                }
                else if (msg == "whoami")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "You are " + e.Message.Chat.Username + " ofcourse, \nYou silly goose!");
                }

                ////No u
                else if (msg == "nou" || msg == "noyou")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "NO U ∞");
                }
                else if (msg == "nou∞+1" || msg == "noyou∞+1")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "GRRRRRR!");
                }

                ////Commands
                else if (e.Message.Text == "/warn" || e.Message.Text == "/ban")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Better look out Marco! >:)");
                }
                else if (e.Message.Text == "/start")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Welcome " + e.Message.Chat.Username + "!\nNice to meet you!\nHope you don't mind me calling you " + e.Message.Chat.FirstName + " instead.\n\nI hope that we'll have a wonderful time together!");
                }
                else if (e.Message.Text == "/info")
                {
                    if (e.Message.Chat.Username == "Sjooooors")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "CHAT STATS\n_____________________________\nCHAT ID: " + e.Message.Chat.Id + "\nCHATTING WITH: " + e.Message.Chat.Username + "\nUSERS FIRST NAME: " + e.Message.Chat.FirstName + "\nLAST NAME: " + e.Message.Chat.LastName + ".");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "You do not have access to this command.");
                    }
                }
                else if (e.Message.Text == "/botkey")
                {
                    if (e.Message.Chat.Username == "Sjooooors")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "BOTKEY REQUEST\n_____________________________\nWARNING: \n\nYOU TRIED TO REQUEST THE BOT KEY.\n\nI WANT YOU TO THINK VERY CAREFULLY,\nARE YOU SURE YOU WANT THE BOT KEY?\n\n/KeyConfirm\n/cancel");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "You do not have access to this command.");
                    }
                }
                else if (e.Message.Text == "/KeyConfirm")
                {
                    if (e.Message.Chat.Username == "Sjooooors")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "As confirmation, please type: 'WApoidjasc89ewA&3r780fs'");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Who do you think you are.");
                    }
                }
                else if (e.Message.Text == "WApoidjasc89ewA&3r780fs")
                {
                    if (e.Message.Chat.Username == "Sjooooors")
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "Thank you,\n\nYou could've asked the botfather you know.\nJust don't mess me up.\n\nHere it is: 508948316:AAHlXv_cOhuLyj6xERVS8ZZiwoeZZ6hPqWM");
                    }
                    else
                    {
                        Bot.SendTextMessageAsync(e.Message.Chat.Id, "You CERTAINLY DO NOT have access to this command.");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                        Console.WriteLine("\n -WARNING-\n!USER:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") KNOWS THE BOT CODE!\n\n");
                    }
                }
                else if (e.Message.Text == "/help")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, @"I can understand these commands : 
                        /warn
                        /ban
                        /credits 

SJORS ONLY COMMANDS:
                        /info
                        /botkey
                ");
                }

                else if (e.Message.Text == "/cancel")
                {
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "Last operation cancelled.");
                }
                else
                {
                    Console.WriteLine("\n -ERROR-\n!Unkown command found:\n" + e.Message.Chat.FirstName + " (@" + e.Message.Chat.Username + ") said: '" + e.Message.Text + "'\nStripped message: '" + msg + "'\n\n");
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, "No idea what you're saying,");
                    Bot.SendTextMessageAsync(e.Message.Chat.Id, @"Please check out : 
                        /help


*Your message has been logged, 
That way we can create a proper response for it.
                    ");
                }


            }

        }
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9+_.∞]+", "", RegexOptions.Compiled);
        }

    }
}
