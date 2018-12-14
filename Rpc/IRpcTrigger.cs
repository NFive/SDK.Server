using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	/// <summary>
	/// Represents the ability send RPC events.
	/// </summary>
	[PublicAPI]
	public interface IRpcTrigger
	{
		void Trigger(params object[] payloads);
	}
}
