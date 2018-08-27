namespace NFive.SDK.Server.Rpc
{
	public interface IRpcTrigger
	{
		void Trigger(params object[] payloads);
	}
}
