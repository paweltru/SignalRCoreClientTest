using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Communication
{
	public class LiveService
	{
		private readonly HubConnection _hubConnection;
		public LiveService()
		{
			var hubConnectionBuilder = new HubConnectionBuilder();
			_hubConnection = hubConnectionBuilder
				.WithUrl("https://localhost:5001/signalrTestHub/")
				.Build();

			_hubConnection.StartAsync(default).Wait();
		 }

		public async Task Send(CancellationToken cancellationToken = default)
		{
			await _hubConnection.SendAsync("SendTestMsg", "Test value", cancellationToken);
		}
	}
}
