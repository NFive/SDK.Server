using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Events
{
	public class ClientSessionEventArgs : ClientEventArgs
	{
		public Session Session { get; }

		public ClientSessionEventArgs(IClient client, Session session) : base(client)
		{
			this.Session = session;
		}
	}
}
