using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	/// <summary>
	/// Represents the ability send RPC events.
	/// </summary>
	[PublicAPI]
	public interface IRpcTrigger
	{
		/// <summary>
		/// Triggers the event with the specified payloads.
		/// </summary>
		/// <param name="payloads">The payloads to send with the event.</param>
		void Trigger(params object[] payloads);
	}
}
