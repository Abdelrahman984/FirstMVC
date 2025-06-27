using Demo.Models;
using FirstMVC.Models;
using Microsoft.AspNetCore.SignalR;

namespace FirstMVC.Hubs
{
    public class ChatHub : Hub
    {
        private readonly AppDbContext _context;
        public ChatHub(AppDbContext context)
        {
            this._context = context;
        }
        public void SendMessage(ChatMessage chatMessage)
        {

            _context.ChatMessages.Add(chatMessage);
            _context.SaveChanges();

            Clients.All.SendAsync("NewMessage", chatMessage);
        }
    }
}
