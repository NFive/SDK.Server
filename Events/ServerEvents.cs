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

		public const string HostingSession = "nfive:server:hostingSession";

		public const string HostedSession = "nfive:server:hostedSession";

		public const string PlayerConnecting = "nfive:server:playerConnecting";

		public const string PlayerDropped = "nfive:server:playerDropped";

		public const string ResourceStart = "nfive:server:resourceStart";

		public const string ResourceStop = "nfive:server:resourceStop";

		public const string RconCommand = "nfive:server:rconCommand";

		public const string Explosion = "nfive:server:explosion";
	}
}
