using System;
using System.Threading.Tasks;
using BotInstagram.Facade;
using BotInstagram.Models;

namespace BotInstagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var sheetId = "15x_dqA0akWW8d5y2518X5aD0XwNbvN37yabON9Qk6Zk";
            var range = "A:Z";
            
            var promotionUrl = "https://www.instagram.com/p/CGBIfQ_Hjqz/";
            var user = "sampa.teu@gmail.com";
            var password = "matcar123";
            var qtdPessoa = QtdPessoa.UmaPessoa;

            new InstaBot(@"C:\Users\sampa\Projects\-DrawBotInstagram\DotNetCore\credentials.json", sheetId, range).Execute(promotionUrl, user, password, qtdPessoa).Wait();
        }
    }
}
