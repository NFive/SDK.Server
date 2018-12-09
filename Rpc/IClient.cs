using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	[PublicAPI]
	public interface IClient
	{
		int Handle { get; }

		string Name { get; }

		string License { get; }

		long? SteamId { get; }

		string EndPoint { get; }

		int Ping { get; }

		IRpcTrigger Event(string @event);
	}
}
