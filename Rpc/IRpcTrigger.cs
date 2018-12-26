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

		/// <summary>
		/// Triggers the event for the specified client with the specified payloads.
		/// </summary>
		/// <param name="client">The client to send the event to.</param>
		/// <param name="payloads">The payloads to send with the event.</param>
		void Trigger(IClient client, params object[] payloads);
	}
}
