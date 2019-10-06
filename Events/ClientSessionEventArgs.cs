using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientSessionEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the session.
		/// </summary>
		/// <value>
		/// The session.
		/// </value>
		public Session Session { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientSessionEventArgs"/> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="session">The session.</param>
		public ClientSessionEventArgs(IClient client, Session session) : base(client)
		{
			this.Session = session;
		}
	}
}
