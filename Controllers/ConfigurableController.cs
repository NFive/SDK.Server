using NFive.SDK.Core.Controllers;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Controllers
{
	public abstract class ConfigurableController<T> : Controller where T : ControllerConfiguration
	{
		protected T Configuration { get; private set; }

		protected ConfigurableController(ILogger logger, IEventManager events, IRpcHandler rpc, T configuration) : base(logger, events, rpc)
		{
			this.Configuration = configuration;
		}

		public virtual void Reload(T configuration) { this.Configuration = configuration; }
	}
}
