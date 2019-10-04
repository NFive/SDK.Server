using JetBrains.Annotations;
using NFive.SDK.Server.Communications;
using System;
using System.Threading.Tasks;

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

		void Emit(string @event, params object[] payload);

		Task<T1> Request<T1>(string @event, params object[] args);

		Task<Tuple<T1, T2>> Request<T1, T2>(string @event, params object[] args);

		Task<Tuple<T1, T2, T3>> Request<T1, T2, T3>(string @event, params object[] args);

		Task<Tuple<T1, T2, T3, T4>> Request<T1, T2, T3, T4>(string @event, params object[] args);

		Task<Tuple<T1, T2, T3, T4, T5>> Request<T1, T2, T3, T4, T5>(string @event, params object[] args);

		void OnRequest(string @event, Action<ICommunicationMessage> action);

		void OnRequest<T>(string @event, Action<ICommunicationMessage, T> action);

		void OnRequest<T1, T2>(string @event, Action<ICommunicationMessage, T1, T2> action);

		void OnRequest<T1, T2, T3>(string @event, Action<ICommunicationMessage, T1, T2, T3> action);

		void OnRequest<T1, T2, T3, T4>(string @event, Action<ICommunicationMessage, T1, T2, T3, T4> action);

		void OnRequest<T1, T2, T3, T4, T5>(string @event, Action<ICommunicationMessage, T1, T2, T3, T4, T5> action);
	}
}
