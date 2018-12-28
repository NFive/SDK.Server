using JetBrains.Annotations;

namespace NFive.SDK.Server.Rpc
{
	[PublicAPI]
	public interface IRpcHandler
	{
		/// <summary>
		/// Events the specified event.
		/// </summary>
		/// <param name="event">The event.</param>
		/// <returns></returns>
		IRpc Event(string @event);
	}
}
