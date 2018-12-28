using System;

namespace NFive.SDK.Server.Rcon
{
	public interface IRconManager
	{
		void Register<T>(string command, Action<T> callback);
	}
}
