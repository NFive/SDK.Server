using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientUserEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the user.
		/// </summary>
		/// <value>
		/// The user.
		/// </value>
		public User User { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientUserEventArgs" /> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="user">The user.</param>
		public ClientUserEventArgs(IClient client, User user) : base(client)
		{
			this.User = user;
		}
	}
}
