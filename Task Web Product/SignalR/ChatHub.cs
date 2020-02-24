using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Task_Web_Product.Models;
using Microsoft.Extensions.Configuration;
using Task_Web_Product.Controllers;

namespace Task_Web_Product.SignalR
{
    
    public class ChatHub :Hub
    {
        private readonly static ConnectionMapping<string> _connections = new ConnectionMapping<string>();
        private readonly ILogger<HomeController> _logger;

        private AppDbContext _AppDbContext;
        public IConfiguration Configuration;

        public ChatHub(ILogger<HomeController> logger, AppDbContext appDbContext, IConfiguration configuration)
        {
            _logger = logger;
            _AppDbContext = appDbContext;
            Configuration = configuration;
        }
         public void SendChatMessage(string from, string to, string message)
        {
            foreach (var connectionId in _connections.GetConnections(to))
                Clients.Client(connectionId).SendAsync("GotMessage", message);

            var msg = new Conversations()
            {
                sender_id = Convert.ToInt32(from),
                receiver_id = Convert.ToInt32(to),
                message = message,
                created_at = DateTime.Now
            };
            _AppDbContext.chat.Add(msg);
            _AppDbContext.SaveChanges();
        }
        public void bindConId(string from)
        {
            if (!_connections.GetConnections(from).Contains(Context.ConnectionId))
                _connections.Add(from, Context.ConnectionId);
        }
        public void removeConId(string from)
        {
            _connections.Remove(from, Context.ConnectionId);
        }
        public override Task OnConnectedAsync()
        {
            string name = Context.UserIdentifier;
            string conID = Context.ConnectionId;
            _logger.LogInformation("name : {0}", name);
            _logger.LogInformation("con ID : {0}", conID);

            return base.OnConnectedAsync();
        }


        // public async Task SendMessage(string to, string message, string from)
        // {
        //     System.Console.WriteLine("HAI");
        //     System.Console.WriteLine(to);
        //     System.Console.WriteLine(message);
        //     await Clients.Client(to).SendAsync("GotAMessage",from,message);
        // }
    }
}