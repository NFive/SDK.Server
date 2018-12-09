using JetBrains.Annotations;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public static class ServerEvents
	{
		public const string ServerInitialized = "nfive:server:serverInitialized";
	}
}
