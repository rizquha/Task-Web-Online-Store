using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Task_Web_Product.SignalR
{
    
    public class ChatHub :Hub
    {
        public async Task SendMessage(string to, string message, string from)
        {
            System.Console.WriteLine("HAI");
            System.Console.WriteLine(to);
            System.Console.WriteLine(message);
            await Clients.Client(to).SendAsync("GotAMessage",from,message);
        }
    }
}