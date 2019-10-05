using JetBrains.Annotations;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientDeferralsEventArgs : ClientEventArgs
	{
		public ConnectionDeferrals Deferrals { get; }

		public ClientDeferralsEventArgs(IClient client, ConnectionDeferrals deferrals) : base(client)
		{
			this.Deferrals = deferrals;
		}
	}
}
