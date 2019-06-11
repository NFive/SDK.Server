using System;
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
		/// Sets the target handle for the RPC message target.
		/// </summary>
		/// <param name="handle">The handle of the RPC message target.</param>
		IRpc Target(int handle);

		/// <summary>
		/// Sets the target client for the RPC message target.
		/// </summary>
		/// <param name="client">The client of the RPC message target.</param>
		IRpc Target(IClient client);

		/// <summary>
		/// Triggers the event with the specified payloads.
		/// </summary>
		/// <param name="payloads">The payloads to send with the event.</param>
		void Trigger(params object[] payloads);
	}
}
