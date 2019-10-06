using JetBrains.Annotations;
using NFive.SDK.Core.Models.Player;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface ICommunicationMessage
	{
		/// <summary>
		/// Gets the client that sent the event.
		/// </summary>
		/// <value>
		/// The client that sent the event.
		/// </value>
		IClient Client { get; }

		/// <summary>
		/// Gets the user belonging to the <see cref="Client"/>.
		/// </summary>
		/// <value>
		/// The user.
		/// </value>
		User User { get; }

		/// <summary>
		/// Gets the user belonging to the <see cref="Client"/>.
		/// </summary>
		/// <value>
		/// The Session.
		/// </value>
		Session Session { get; }

		/// <summary>
		/// Replies to the event with the specified payloads.
		/// </summary>
		/// <param name="payloads">The payloads to reply to the event with.</param>
		void Reply(params object[] payloads);
	}
}
