using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	[PublicAPI]
	public interface IRpcHandler
	{
		IRpc Event(string @event);
	}
}
