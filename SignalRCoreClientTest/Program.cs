using Communication;
using System;
using System.Threading.Tasks;

namespace SignalRCoreClientTest
{
	class Program
	{
		static async Task Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			LiveService tmp = new LiveService();
			await tmp.Send();
		}
	}
}
