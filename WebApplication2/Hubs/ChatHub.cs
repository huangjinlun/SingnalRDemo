using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Hubs
{
    public class ChatHub: Hub
    {
        public void Hello(string str)
        {
            Clients.All.hello(str);
        }
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}