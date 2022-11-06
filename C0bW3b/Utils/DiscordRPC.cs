using DiscordRPC;
using DiscordRPC.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C0bW3b.Utils
{
    public class DiscordRPC
    {
        public static DiscordRpcClient client = new DiscordRpcClient("1026818126681227324");

        public static void Initialize()
        {
            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) => Console.WriteLine("Received Ready from user {0}", e.User.Username);

            client.OnPresenceUpdate += (sender, e) => Console.WriteLine("Received Update! {0}", e.Presence);

            //Connect to the RPC
            client.Initialize();

            //Set the rich presence
            //Call this as many times as you want and anywhere in your code.
            client.SetPresence(new RichPresence()
            {
                Details = "Advanced Web Crawler",
                State = "The fastest way to find websites!",
                Buttons = new Button[]
                {
                    new Button()
                    {
                        Label = "Download",
                        Url = "https://github.com/Zebratic/C0bW3b"
                    },
                },
                Assets = new Assets()
                {
                    LargeImageKey = "spider_icon",
                    LargeImageText = "Zebratic's C0bW3b - Advanced Web Crawler",
                }
            });

            int timeout = 0;
            while (client.CurrentUser == null)
            {
                timeout++;
                if (timeout > 20) // 2 seconds
                    break;
                else
                    Thread.Sleep(100);
            }
        }

        public static void UpdatePresence(string details = null, string state = null, Button[] buttons = null, Assets assets = null)
        {
            RichPresence presence = client.CurrentPresence;
            if (!string.IsNullOrWhiteSpace(details)) presence.Details = details;
            if (!string.IsNullOrWhiteSpace(state)) presence.State = state;
            if (buttons != null) presence.Buttons = buttons;
            if (assets != null) presence.Assets = assets;

            client.SetPresence(presence);
        }
    }
}