using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rpc;
using JetBrains.Annotations;

namespace NFive.SDK.Server.Controllers
{
	/// <summary>
	/// Base class for a server script.
	/// </summary>
	[PublicAPI]
	public abstract class Controller
	{
		/// <summary>
		/// The message logger,
		/// </summary>
		protected readonly ILogger Logger;

		/// <summary>
		/// The server event manager.
		/// </summary>
		protected readonly IEventManager Events;

		/// <summary>
		/// The RPC handler.
		/// </summary>
		protected readonly IRpcHandler Rpc;

		/// <summary>
		/// Initializes a new instance of the <see cref="Controller"/> class.
		/// </summary>
		/// <param name="logger">The message logger.</param>
		/// <param name="events">The server event manager.</param>
		/// <param name="rpc">The RPC handler.</param>
		protected Controller(ILogger logger, IEventManager events, IRpcHandler rpc)
		{
			this.Logger = logger;
			this.Events = events;
			this.Rpc = rpc;
		}

		/// <summary>
		/// Reloads this controllers configuration.
		/// </summary>
		public virtual void Reload() { }
	}
}
