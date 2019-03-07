using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Events
{
	public class ClientReconnectEventArgs : ClientEventArgs
	{
		public Session OldSession { get; }

		public Session NewSession { get; }

		public ClientReconnectEventArgs(IClient client, Session oldSession, Session newSession) : base(client)
		{
			this.OldSession = oldSession;
			this.NewSession = newSession;
		}
	}
}
