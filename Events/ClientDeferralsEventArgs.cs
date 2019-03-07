using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Events
{
	public class ClientDeferralsEventArgs : ClientEventArgs
	{
		public Deferrals Deferrals { get; }

		public ClientDeferralsEventArgs(IClient client, Deferrals deferrals) : base(client)
		{
			this.Deferrals = deferrals;
		}
	}
}
