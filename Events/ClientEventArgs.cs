using JetBrains.Annotations;
using NFive.SDK.Server.Communications;
using System;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientEventArgs : EventArgs
	{
		public IClient Client { get; }

		public ClientEventArgs(IClient client)
		{
			this.Client = client;
		}
	}
}
