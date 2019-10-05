using JetBrains.Annotations;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface ICommunicationTarget
	{
		string Event { get; }

		ICommunicationTransmitClient ToClient(IClient client);

		ICommunicationReceiveClient FromClient(IClient client);

		ICommunicationTransmitClient ToClients();

		ICommunicationReceiveClient FromClients();

		ICommunicationTransmitServer ToServer();

		ICommunicationReceiveServer FromServer();
	}
}
