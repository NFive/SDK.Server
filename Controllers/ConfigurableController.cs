using NFive.SDK.Core.Controllers;
using NFive.SDK.Core.Diagnostics;
using NFive.SDK.Server.Events;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Controllers
{
	public abstract class ConfigurableController<T> : Controller where T : ControllerConfiguration
	{
		protected readonly T Configuration;

		protected ConfigurableController(ILogger logger, IEventManager events, IRpcHandler rpc, T configuration) : base(logger, events, rpc)
		{
			this.Configuration = configuration;
		}
	}
}
