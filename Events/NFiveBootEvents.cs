using JetBrains.Annotations;

namespace NFive.SDK.Server.Events
{
	/// <summary>
	/// NFive server boot events which are sent over the server event manager.
	/// </summary>
	[PublicAPI]
	public static class NFiveBootEvents
	{
		/// <summary>
		/// Event which is used to request the timestamp of when the server started this boot.
		/// </summary>
		public const string GetTime = "nfive:server:boot:getTime";

		/// <summary>
		/// Event which is used to request the timestamp of when the server started last boot.
		/// </summary>
		public const string GetLastTime = "nfive:server:boot:getLastTime";

		/// <summary>
		/// Event which is used to request the timestamp of when the server shutdown last boot.
		/// </summary>
		public const string GetLastActiveTime = "nfive:server:boot:getLastActiveTime";
	}
}
