using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Events
{
	public class ClientSessionDeferralsEventArgs : ClientSessionEventArgs
	{
		public Deferrals Deferrals { get; }

		public ClientSessionDeferralsEventArgs(IClient client, Session session, Deferrals deferrals) : base(client, session)
		{
			this.Deferrals = deferrals;
		}
	}
}
