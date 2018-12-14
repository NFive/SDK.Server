using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;

namespace NFive.SDK.Server.Rpc
{
	/// <summary>
	/// Represents a received RPC event.
	/// </summary>
	[PublicAPI]
	public interface IRpcEvent
	{
		string Event { get; }

		IClient Client { get; }

		User User { get; }

		void Reply(params object[] payloads);
	}
}
