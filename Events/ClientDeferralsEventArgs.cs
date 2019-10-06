using JetBrains.Annotations;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public class ClientDeferralsEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the deferrals.
		/// </summary>
		/// <value>
		/// The deferrals.
		/// </value>
		public ConnectionDeferrals Deferrals { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientDeferralsEventArgs"/> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="deferrals">The deferrals.</param>
		public ClientDeferralsEventArgs(IClient client, ConnectionDeferrals deferrals) : base(client)
		{
			this.Deferrals = deferrals;
		}
	}
}
