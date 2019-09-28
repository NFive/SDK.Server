using JetBrains.Annotations;
using System;
using System.Threading.Tasks;
using NFive.SDK.Server.Communications;

namespace NFive.SDK.Server.Events
{
	/// <summary>
	/// Manager to send and receive server events across plugins.
	/// </summary>
	[PublicAPI]
	public interface IEventManager
	{
		/// <summary>
		/// Attaches a handler to a specified event.
		/// </summary>
		/// <param name="event">The event to attach to.</param>
		/// <param name="action">The callback to run when the event fires.</param>
		void On(string @event, Action<ICommunicationMessage> action);

		/// <summary>
		/// Attaches a handler to a specified event.
		/// </summary>
		/// <typeparam name="T">The type of the first callback argument.</typeparam>
		/// <param name="event">The event to attach to.</param>
		/// <param name="action">The callback to run when the event fires.</param>
		void On<T>(string @event, Action<ICommunicationMessage, T> action);

		/// <summary>
		/// Attaches a handler to a specified event.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback argument.</typeparam>
		/// <typeparam name="T2">The type of the second callback argument.</typeparam>
		/// <param name="event">The event to attach to.</param>
		/// <param name="action">The callback to run when the event fires.</param>
		void On<T1, T2>(string @event, Action<ICommunicationMessage, T1, T2> action);

		/// <summary>
		/// Attaches a handler to a specified event.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback argument.</typeparam>
		/// <typeparam name="T2">The type of the second callback argument.</typeparam>
		/// <typeparam name="T3">The type of the third callback argument.</typeparam>
		/// <param name="event">The event to attach to.</param>
		/// <param name="action">The callback to run when the event fires.</param>
		void On<T1, T2, T3>(string @event, Action<ICommunicationMessage, T1, T2, T3> action);

		/// <summary>
		/// Attaches a handler to a specified event.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback argument.</typeparam>
		/// <typeparam name="T2">The type of the second callback argument.</typeparam>
		/// <typeparam name="T3">The type of the third callback argument.</typeparam>
		/// <typeparam name="T4">The type of the forth callback argument.</typeparam>
		/// <param name="event">The event to attach to.</param>
		/// <param name="action">The callback to run when the event fires.</param>
		void On<T1, T2, T3, T4>(string @event, Action<ICommunicationMessage, T1, T2, T3, T4> action);

		/// <summary>
		/// Attaches a handler to a specified event.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback argument.</typeparam>
		/// <typeparam name="T2">The type of the second callback argument.</typeparam>
		/// <typeparam name="T3">The type of the third callback argument.</typeparam>
		/// <typeparam name="T4">The type of the forth callback argument.</typeparam>
		/// <typeparam name="T5">The type of the fifth callback argument.</typeparam>
		/// <param name="event">The event to attach to.</param>
		/// <param name="action">The callback to run when the event fires.</param>
		void On<T1, T2, T3, T4, T5>(string @event, Action<ICommunicationMessage, T1, T2, T3, T4, T5> action);

		/// <summary>
		/// Raises the specified event.
		/// </summary>
		/// <param name="event">The event to raise.</param>
		[Obsolete]
		void Raise(string @event);

		/// <summary>
		/// Raises the specified event with an argument.
		/// </summary>
		/// <typeparam name="T">The type of the first event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		[Obsolete]
		void Raise<T>(string @event, T arg1);

		/// <summary>
		/// Raises the specified event with arguments.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		[Obsolete]
		void Raise<T1, T2>(string @event, T1 arg1, T2 arg2);

		/// <summary>
		/// Raises the specified event with arguments.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <typeparam name="T3">The type of the third event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		/// <param name="arg3">The third event argument.</param>
		[Obsolete]
		void Raise<T1, T2, T3>(string @event, T1 arg1, T2 arg2, T3 arg3);

		/// <summary>
		/// Raises the specified event with arguments.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <typeparam name="T3">The type of the third event argument.</typeparam>
		/// <typeparam name="T4">The type of the forth event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		/// <param name="arg3">The third event argument.</param>
		/// <param name="arg4">The forth event argument.</param>
		[Obsolete]
		void Raise<T1, T2, T3, T4>(string @event, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

		/// <summary>
		/// Raises the specified event with arguments.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <typeparam name="T3">The type of the third event argument.</typeparam>
		/// <typeparam name="T4">The type of the forth event argument.</typeparam>
		/// <typeparam name="T5">The type of the fifth event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		/// <param name="arg3">The third event argument.</param>
		/// <param name="arg4">The forth event argument.</param>
		/// <param name="arg5">The fifth event argument.</param>
		[Obsolete]
		void Raise<T1, T2, T3, T4, T5>(string @event, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

		void Fire(string @event, params object[] payload);

		/// <summary>
		/// Raises the specified event asynchronously and returns when the event has been handled.
		/// </summary>
		/// <param name="event">The event to raise.</param>
		Task RaiseAsync(string @event);

		/// <summary>
		/// Raises the specified event an argument asynchronously and returns when the event has been handled.
		/// </summary>
		/// <typeparam name="T">The type of the event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The event argument.</param>
		/// <returns></returns>
		Task RaiseAsync<T>(string @event, T arg1);

		/// <summary>
		/// Raises the specified event with arguments asynchronously and returns when the event has been handled.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		/// <returns></returns>
		Task RaiseAsync<T1, T2>(string @event, T1 arg1, T2 arg2);

		/// <summary>
		/// Raises the specified event with arguments asynchronously and returns when the event has been handled.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <typeparam name="T3">The type of the third event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		/// <param name="arg3">The third event argument.</param>
		/// <returns></returns>
		Task RaiseAsync<T1, T2, T3>(string @event, T1 arg1, T2 arg2, T3 arg3);

		/// <summary>
		/// Raises the specified event with arguments asynchronously and returns when the event has been handled.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <typeparam name="T3">The type of the third event argument.</typeparam>
		/// <typeparam name="T4">The type of the forth event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		/// <param name="arg3">The third event argument.</param>
		/// <param name="arg4">The forth event argument.</param>
		/// <returns></returns>
		Task RaiseAsync<T1, T2, T3, T4>(string @event, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

		/// <summary>
		/// Raises the specified event with arguments asynchronously and returns when the event has been handled.
		/// </summary>
		/// <typeparam name="T1">The type of the first event argument.</typeparam>
		/// <typeparam name="T2">The type of the second event argument.</typeparam>
		/// <typeparam name="T3">The type of the third event argument.</typeparam>
		/// <typeparam name="T4">The type of the forth event argument.</typeparam>
		/// <typeparam name="T5">The type of the fifth event argument.</typeparam>
		/// <param name="event">The event to raise.</param>
		/// <param name="arg1">The first event argument.</param>
		/// <param name="arg2">The second event argument.</param>
		/// <param name="arg3">The third event argument.</param>
		/// <param name="arg4">The forth event argument.</param>
		/// <param name="arg5">The fifth event argument.</param>
		Task RaiseAsync<T1, T2, T3, T4, T5>(string @event, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);


		void OnRequest<TReturn>(string @event, Func<TReturn> action);

		void OnRequest<T1, TReturn>(string @event, Func<T1, TReturn> action);

		void OnRequest<T1, T2, TReturn>(string @event, Func<T1, T2, TReturn> action);

		void OnRequest<T1, T2, T3, TReturn>(string @event, Func<T1, T2, T3, TReturn> action);

		void OnRequest<T1, T2, T3, T4, TReturn>(string @event, Func<T1, T2, T3, T4, TReturn> action);

		void OnRequest<T1, T2, T3, T4, T5, TReturn>(string @event, Func<T1, T2, T3, T4, T5, TReturn> action);

		Task<T1> Request<T1>(string @event, params object[] args);

		Task<Tuple<T1, T2>> Request<T1, T2>(string @event, params object[] args);

		Task<Tuple<T1, T2, T3>> Request<T1, T2, T3>(string @event, params object[] args);

		Task<Tuple<T1, T2, T3, T4>> Request<T1, T2, T3, T4>(string @event, params object[] args);

		Task<Tuple<T1, T2, T3, T4, T5>> Request<T1, T2, T3, T4, T5>(string @event, params object[] args);
	}
}
