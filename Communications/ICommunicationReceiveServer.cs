using System;

namespace NFive.SDK.Server.Communications
{
	public interface ICommunicationReceiveServer
	{
		void On(Action callback);

		void On<T>(Action<T> callback);

		void On<T1, T2>(Action<T1, T2> callback);

		void On<T1, T2, T3>(Action<T1, T2, T3> callback);

		void On<T1, T2, T3, T4>(Action<T1, T2, T3, T4> callback);

		void On<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> callback);
	}
}
