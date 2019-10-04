using JetBrains.Annotations;
using NFive.SDK.Core.Controllers;
using NFive.SDK.Core.Diagnostics;

namespace NFive.SDK.Server.Controllers
{
	/// <inheritdoc />
	/// <summary>
	/// Base class for a server script with automatically loaded configuration file.
	/// </summary>
	/// <typeparam name="T">The type of the configuration to load.</typeparam>
	/// <seealso cref="Controller" />
	[PublicAPI]
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
		/// <param name="configuration">The configuration loaded from file.</param>
		protected ConfigurableController(ILogger logger, T configuration) : base(logger)
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
