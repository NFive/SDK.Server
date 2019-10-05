using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientUserEventArgs : ClientEventArgs
	{
		public User User { get; }

		public ClientUserEventArgs(IClient client, User user) : base(client)
		{
			this.User = user;
		}
	}
}
