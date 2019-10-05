using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientSessionEventArgs : ClientEventArgs
	{
		public Session Session { get; }

		public ClientSessionEventArgs(IClient client, Session session) : base(client)
		{
			this.Session = session;
		}
	}
}
