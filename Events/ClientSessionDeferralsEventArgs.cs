using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientSessionDeferralsEventArgs : ClientSessionEventArgs
	{
		/// <summary>
		/// Gets the deferrals.
		/// </summary>
		/// <value>
		/// The deferrals.
		/// </value>
		public ConnectionDeferrals Deferrals { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientSessionDeferralsEventArgs" /> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="session">The session.</param>
		/// <param name="deferrals">The deferrals.</param>
		public ClientSessionDeferralsEventArgs(IClient client, Session session, ConnectionDeferrals deferrals) : base(client, session)
		{
			this.Deferrals = deferrals;
		}
	}
}
