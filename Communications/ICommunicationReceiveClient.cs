using System;
using NFive.SDK.Server.Rpc;

namespace NFive.SDK.Server.Communications
{
	public interface ICommunicationReceiveClient
	{
		void On(Action<ICommunicationMessage> callback);

		void On<T>(Action<ICommunicationMessage, T> callback);

		void On<T1, T2>(Action<ICommunicationMessage, T1, T2> callback);

		void On<T1, T2, T3>(Action<ICommunicationMessage, T1, T2, T3> callback);

		void On<T1, T2, T3, T4>(Action<ICommunicationMessage, T1, T2, T3, T4> callback);

		void On<T1, T2, T3, T4, T5>(Action<ICommunicationMessage, T1, T2, T3, T4, T5> callback);
	}
}
