using JetBrains.Annotations;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface ICommunicationTarget
	{
		/// <summary>
		/// Returns a communication adapter for transmitting, targeting the supplied client.
		/// </summary>
		/// <param name="client">The client the adapter will communicate with.</param>
		/// <returns>A client targeted communication adapter for transmitting.</returns>
		ICommunicationTransmitClient ToClient(IClient client);

		/// <summary>
		/// Returns a communication adapter adapter for receiving, targeting the supplied client.
		/// </summary>
		/// <param name="client">The client the adapter will communicate with.</param>
		/// <returns>A client targeted communication adapter for receiving.</returns>
		ICommunicationReceiveClient FromClient(IClient client);

		/// <summary>
		/// Returns a communication adapter adapter for transmitting, targeting all clients.
		/// </summary>
		/// <returns>A communication adapter for transmitting to all clients.</returns>
		ICommunicationTransmitClient ToClients();

		/// <summary>
		/// Returns a communication adapter for receiving, targeting all clients.
		/// </summary>
		/// <returns>A communication adapter for receiving from all clients.</returns>
		ICommunicationReceiveClient FromClients();

		/// <summary>
		/// Returns a communication adapter adapter for transmitting to the server.
		/// </summary>
		/// <returns>A server targeted communication adapter for transmitting.</returns>
		ICommunicationTransmitServer ToServer();

		/// <summary>
		/// Returns a communication adapter for receiving from the server.
		/// </summary>
		/// <returns>A server targeted communication adapter for receiving.</returns>
		ICommunicationReceiveServer FromServer();
	}
}
