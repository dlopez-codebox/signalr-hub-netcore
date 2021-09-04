using Microsoft.AspNetCore.SignalR;
using signalr.Hubs.Clients;
using signalr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signalr.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {

        public async Task SendMessage(ChatMessage message) {

            await Clients.All.ReceiveMessage(message);
        
        }
    }
}
