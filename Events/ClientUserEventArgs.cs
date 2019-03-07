using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Events
{
	public class ClientUserEventArgs : ClientEventArgs
	{
		public User User { get; }

		public ClientUserEventArgs(IClient client, User user) : base(client)
		{
			this.User = user;
		}
	}
}
