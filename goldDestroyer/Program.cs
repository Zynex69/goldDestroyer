using System;
using System.Collections.Generic;
using System.Threading;
using System.Net.Http;

namespace goldDestroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "goldDestroyer - Webhook Destroyer by goldblack";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Webhook: ");
            string webhook = Console.ReadLine();

            Console.Write("Message: ");
            string message = Console.ReadLine();

            Console.Write("Threads: ");
            string threadsString = Console.ReadLine();

            int threads = Convert.ToInt32(threadsString);
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i=0; i<threads; i++)
            {
                Webhook(webhook, message);
                Console.WriteLine("Message number [" + i + "] has been sent.");
                Thread.Sleep(500);
            }


        }

        public static void Webhook(string URL, string MSG)
        {
            HttpClient client = new HttpClient();
            Dictionary<string, string> contents = new Dictionary<string, string>
                {
                    { "content", MSG },
                    { "username", "EUROPA Fucker" },
                    { "avatar_url", "https://cdn.discordapp.com/attachments/696080024742395914/705121650542379159/europa.jpg" }
                };

            client.PostAsync(URL, new FormUrlEncodedContent(contents)).GetAwaiter().GetResult();
        }
    }
}
