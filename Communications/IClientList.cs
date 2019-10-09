using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using NFive.SDK.Server.Events;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface IClientList
	{
		/// <summary>
		/// Gets the clients.
		/// </summary>
		/// <value>
		/// The clients.
		/// </value>
		List<IClient> Clients { get; }

		/// <summary>
		/// Occurs when [client added].
		/// </summary>
		event EventHandler<ClientEventArgs> ClientAdded;

		/// <summary>
		/// Occurs when [client removed].
		/// </summary>
		event EventHandler<ClientEventArgs> ClientRemoved;
	}
}
