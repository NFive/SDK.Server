using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientSessionDeferralsEventArgs : ClientSessionEventArgs
	{
		public ConnectionDeferrals Deferrals { get; }

		public ClientSessionDeferralsEventArgs(IClient client, Session session, ConnectionDeferrals deferrals) : base(client, session)
		{
			this.Deferrals = deferrals;
		}
	}
}
