using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Communications
{
	public interface ICommunicationTarget
	{
		IEventManager EventManager { get; }
		string Event { get; }
		ICommunicationTransmitClient ToClient(IClient client);
		ICommunicationReceiveClient FromClient(IClient client);
		ICommunicationTransmitClient ToClients();
		ICommunicationReceiveClient FromClients();
		ICommunicationTransmitServer ToServer();
		ICommunicationReceiveServer FromServer();
	}
}
