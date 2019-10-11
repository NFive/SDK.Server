using JetBrains.Annotations;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface IConnectionDeferrals
	{
		string Message { set; }

		void Defer();

		void ShowCard(string json);

		void Allow();

		void Reject(string message);
	}
}
