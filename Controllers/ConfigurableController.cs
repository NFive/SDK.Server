using NFive.SDK.Core.Controllers;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rcon;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Controllers
{
	/// <inheritdoc />
	/// <summary>
	/// Base class for a server script with automatically loaded configuration file.
	/// </summary>
	/// <typeparam name="T">The type of the configuration to load.</typeparam>
	/// <seealso cref="Controller" />
	public abstract class ConfigurableController<T> : Controller where T : IControllerConfiguration
	{
		/// <summary>
		/// Gets the configuration loaded from file.
		/// </summary>
		/// <value>
		/// The configuration loaded from file.
		/// </value>
		protected T Configuration { get; private set; }

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurableController{T}"/> class.
		/// </summary>
		/// <param name="logger">The message logger.</param>
		/// <param name="events">The server event manager.</param>
		/// <param name="rpc">The RPC handler.</param>
		/// <param name="rcon">The RCON handler.</param>
		/// <param name="configuration">The configuration loaded from file.</param>
		protected ConfigurableController(ILogger logger, IEventManager events, IRpcHandler rpc, IRconManager rcon, T configuration) : base(logger, events, rpc, rcon)
		{
			this.Configuration = configuration;
		}

		/// <summary>
		/// Reloads this controllers configuration.
		/// </summary>
		/// <param name="configuration">The updated controller configuration.</param>
		public virtual void Reload(T configuration)
		{
			this.Configuration = configuration;
		}
	}
}
