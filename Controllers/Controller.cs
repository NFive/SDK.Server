using JetBrains.Annotations;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rcon;
using NFive.SDK.Server.Rpc;
using System.Threading.Tasks;

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
		/// The RCON handler.
		/// </summary>
		protected readonly IRconManager Rcon;

		/// <summary>
		/// Initializes a new instance of the <see cref="Controller"/> class.
		/// </summary>
		/// <param name="logger">The message logger.</param>
		/// <param name="events">The server event manager.</param>
		/// <param name="rpc">The RPC handler.</param>
		/// <param name="rcon">The RCON handler.</param>
		protected Controller(ILogger logger, IEventManager events, IRpcHandler rpc, IRconManager rcon)
		{
			this.Logger = logger;
			this.Events = events;
			this.Rpc = rpc;
			this.Rcon = rcon;
		}

		public virtual Task Loaded() => Task.FromResult(0);

		public virtual Task Started() => Task.FromResult(0);

		/// <summary>
		/// Reloads this controllers configuration.
		/// </summary>
		public virtual void Reload() { }
	}
}
