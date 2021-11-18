using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRNotification.Data
{
    public class ChatHub :Hub
    {
        public async Task sendMessage(string sender,string receiver,string msgTitle,string msgBody)
        {
            await Clients.All.SendAsync("ReceiveMessage",sender,receiver,msgTitle,msgBody);
            
        }
    }
}