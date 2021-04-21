using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRServer.Hubs
{
	public class TestHub : Hub
	{
		public async Task SendTestMsg(string value)
		{
			await Console.Out.WriteAsync($"{value} received");
		}
	}
}
