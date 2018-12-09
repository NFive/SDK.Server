using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	[PublicAPI]
	public interface IRpcTrigger
	{
		void Trigger(params object[] payloads);
	}
}
