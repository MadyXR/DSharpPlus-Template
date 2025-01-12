using System;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.EventArgs;
using DSharpPlus.CommandsNext;
using DSharpPlusBot.config;
using DSharpPlus.Net.Models;

namespace DSharpPlusBot
{
    internal class Program
    {
        private static DiscordClient Client { get; set; }
        private static CommandsNextExtension Commands { get; set; }

        static async Task Main(string[] args)
        {
            var jsonReader = new JSONReader();
            await jsonReader.ReadJSON();

            var discordConfig = new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                Token = jsonReader.token,
                TokenType = TokenType.Bot,
                AutoReconnect = true
            };

            Client = new DiscordClient(discordConfig);

            
            Client.Ready += Client_Ready;

            await Client.ConnectAsync();
            await Task.Delay(-1); 
        }

        
        private static async Task Client_Ready(DiscordClient client, ReadyEventArgs e)
        {
            Console.WriteLine("Bot is Ready!");
        }
    }
}
