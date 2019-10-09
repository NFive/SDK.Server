using System;
using JetBrains.Annotations;

namespace NFive.SDK.Server.Rcon
{
	[PublicAPI]
	public interface IRconManager
	{
		void Register(string command, Action callback);

		void Register<T>(string command, Action<T> callback);
	}
}
