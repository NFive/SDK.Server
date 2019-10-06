using JetBrains.Annotations;
using NFive.SDK.Server.Events;
using System;
using System.Collections.Generic;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface IClientList
	{
		/// <summary>
		/// Occurs when [client added].
		/// </summary>
		event EventHandler<ClientEventArgs> ClientAdded;

		/// <summary>
		/// Occurs when [client removed].
		/// </summary>
		event EventHandler<ClientEventArgs> ClientRemoved;

		/// <summary>
		/// Gets the clients.
		/// </summary>
		/// <value>
		/// The clients.
		/// </value>
		List<IClient> Clients { get; }
	}
}
