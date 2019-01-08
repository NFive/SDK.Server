using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	/// <summary>
	/// Represents a client connected to the server
	/// </summary>
	[PublicAPI]
	public interface IClient
	{
		/// <summary>
		/// Gets the server client handle.
		/// </summary>
		/// <value>
		/// The server client handle.
		/// </value>
		int Handle { get; }

		/// <summary>
		/// Gets the client name.
		/// </summary>
		/// <value>
		/// The client name.
		/// </value>
		string Name { get; }

		/// <summary>
		/// Gets the client license.
		/// </summary>
		/// <value>
		/// The client license.
		/// </value>
		string License { get; }

		/// <summary>
		/// Gets the client Steam identifier.
		/// </summary>
		/// <value>
		/// The client Steam identifier.
		/// </value>
		long? SteamId { get; }

		/// <summary>
		/// Gets the client end point.
		/// </summary>
		/// <value>
		/// The end point.
		/// </value>
		string EndPoint { get; }

		/// <summary>
		/// Gets the client ping.
		/// </summary>
		/// <value>
		/// The client ping.
		/// </value>
		int Ping { get; }

		/// <summary>
		/// Gets the specified event on this client.
		/// </summary>
		/// <param name="event">The event on this client.</param>
		/// <returns></returns>
		IRpcTrigger Event(string @event);
	}
}
