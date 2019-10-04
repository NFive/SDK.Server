using JetBrains.Annotations;
using NFive.SDK.Server.Events;
using System;
using System.Collections.Generic;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface IClientList
	{
		event EventHandler<ClientEventArgs> ClientAdded;

		event EventHandler<ClientEventArgs> ClientRemoved;

		List<IClient> Clients { get; }
	}
}
