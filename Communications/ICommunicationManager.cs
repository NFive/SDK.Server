using JetBrains.Annotations;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface ICommunicationManager
	{
		ICommunicationTarget Event(string @event);
	}
}
