using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientReconnectEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the old session.
		/// </summary>
		/// <value>
		/// The old session.
		/// </value>
		public Session OldSession { get; }

		/// <summary>
		/// Gets the new session.
		/// </summary>
		/// <value>
		/// The new session.
		/// </value>
		public Session NewSession { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientReconnectEventArgs" /> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="oldSession">The old session.</param>
		/// <param name="newSession">The new session.</param>
		public ClientReconnectEventArgs(IClient client, Session oldSession, Session newSession) : base(client)
		{
			this.OldSession = oldSession;
			this.NewSession = newSession;
		}
	}
}
