using CitizenFX.Core;

namespace NFive.SDK.Server
{
	public interface IBaseScriptProxy
	{
		EventHandlerDictionary EventHandlers { get; }

		ExportDictionary Exports { get; }

		PlayerList Players { get; }
	}
}
