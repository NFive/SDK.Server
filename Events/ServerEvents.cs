using JetBrains.Annotations;

namespace NFive.SDK.Server.Events
{
	/// <summary>
	/// Core NFive server events which are sent over the server event manager.
	/// </summary>
	[PublicAPI]
	public static class ServerEvents
	{
		/// <summary>
		/// The server initialized event.
		/// Fired as soon as the server has initialized.
		/// </summary>
		public const string ServerInitialized = "nfive:server:serverInitialized";
	}
}
