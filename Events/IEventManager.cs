using System;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace NFive.SDK.Server.Events
{
	[PublicAPI]
	public interface IEventManager
	{
		void On(string @event, Action action);

		void On<T>(string @event, Action<T> action);

		void On<T1, T2>(string @event, Action<T1, T2> action);

		void On<T1, T2, T3>(string @event, Action<T1, T2, T3> action);

		void On<T1, T2, T3, T4>(string @event, Action<T1, T2, T3, T4> action);

		void On<T1, T2, T3, T4, T5>(string @event, Action<T1, T2, T3, T4, T5> action);


		void Raise(string @event);

		void Raise<T>(string @event, T p1);

		void Raise<T1, T2>(string @event, T1 p1, T2 p2);

		void Raise<T1, T2, T3>(string @event, T1 p1, T2 p2, T3 p3);

		void Raise<T1, T2, T3, T4>(string @event, T1 p1, T2 p2, T3 p3, T4 p4);

		void Raise<T1, T2, T3, T4, T5>(string @event, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);


		Task RaiseAsync(string @event);

		Task RaiseAsync<T>(string @event, T p1);

		Task RaiseAsync<T1, T2>(string @event, T1 p1, T2 p2);

		Task RaiseAsync<T1, T2, T3>(string @event, T1 p1, T2 p2, T3 p3);

		Task RaiseAsync<T1, T2, T3, T4>(string @event, T1 p1, T2 p2, T3 p3, T4 p4);

		Task RaiseAsync<T1, T2, T3, T4, T5>(string @event, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5);


		void OnRequest<TReturn>(string @event, Func<TReturn> action);

		void OnRequest<T1, TReturn>(string @event, Func<T1, TReturn> action);

		void OnRequest<T1, T2, TReturn>(string @event, Func<T1, T2, TReturn> action);

		void OnRequest<T1, T2, T3, TReturn>(string @event, Func<T1, T2, T3, TReturn> action);

		void OnRequest<T1, T2, T3, T4, TReturn>(string @event, Func<T1, T2, T3, T4, TReturn> action);

		void OnRequest<T1, T2, T3, T4, T5, TReturn>(string @event, Func<T1, T2, T3, T4, T5, TReturn> action);


		TReturn Request<TReturn>(string @event);

		TReturn Request<T1, TReturn>(string @event, T1 arg);

		TReturn Request<T1, T2, TReturn>(string @event, T1 arg);

		TReturn Request<T1, T2, T3, TReturn>(string @event, T1 arg);

		TReturn Request<T1, T2, T3, T4, TReturn>(string @event, T1 arg);

		TReturn Request<T1, T2, T3, T4, T5, TReturn>(string @event, T1 arg);
	}
}
