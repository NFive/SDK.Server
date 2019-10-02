using JetBrains.Annotations;
using NFive.SDK.Core.Diagnostics;
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
		/// Initializes a new instance of the <see cref="Controller"/> class.
		/// </summary>
		/// <param name="logger">The message logger.</param>
		protected Controller(ILogger logger)
		{
			this.Logger = logger;
		}

		public virtual Task Loaded() => Task.FromResult(0);

		public virtual Task Started() => Task.FromResult(0);

		/// <summary>
		/// Reloads this controllers configuration.
		/// </summary>
		public virtual void Reload() { }
	}
}
