using System;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Events
{
	public class ClientEventArgs : EventArgs
	{
		public IClient Client { get; }

		public ClientEventArgs(IClient client)
		{
			this.Client = client;
		}
	}
}
