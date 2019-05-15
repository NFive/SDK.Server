namespace NFive.SDK.Server.Rpc
{
	/// <inheritdoc />
	/// <summary>
	/// Represents the ability send and receive RPC events.
	/// </summary>
	/// <seealso cref="IRpcTrigger" />
	/// <seealso cref="IRpcAttach" />
	public interface IRpc : IRpcTrigger, IRpcAttach { }
}
