using JetBrains.Annotations;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public static class SessionEvents
	{
		public const string DisconnectPlayer = "nfive:server:sessionmanager:disconnectPlayer";

		public const string ClientConnecting = "nfive:server:sessionmanager:clientConnecting";
		public const string UserCreating = "nfive:server:sessionmanager:userCreating";
		public const string UserCreated = "nfive:server:sessionmanager:userCreated";
		public const string SessionCreating = "nfive:server:sessionmanager:sessionCreating";
		public const string SessionCreated = "nfive:server:sessionmanager:sessionCreated";
		public const string ClientConnected = "nfive:server:sessionmanager:clientConnected";
		public const string ClientReconnecting = "nfive:server:sessionmanager:clientReconnecting";
		public const string ClientReconnected = "nfive:server:sessionmanager:clientReconnected";
		public const string ClientDisconnecting = "nfive:server:sessionmanager:clientDisconnecting";
		public const string ClientDisconnected = "nfive:server:sessionmanager:clientDisconnected";
		public const string ClientInitializing = "nfive:server:sessionmanager:clientInitializing";
		public const string ClientInitialized = "nfive:server:sessionmanager:clientInitialized";
		public const string SessionTimedOut = "nfive:server:sessionmanager:sessionTimedOut";

		public const string GetMaxPlayers = "nfive:server:sessionmanager:getMaxPlayers";
		public const string GetCurrentSessionsCount = "nfive:server:sessionmanager:getCurrentSessionsCount";
		public const string GetCurrentSessions = "nfive:server:sessionmanager:getCurrentSessions";
	}
}
