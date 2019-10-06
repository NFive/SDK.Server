using JetBrains.Annotations;
using System;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface ICommunicationReceive
	{
		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <param name="callback">The callback.</param>
		void On(Action<ICommunicationMessage> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T">The type of the first callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void On<T>(Action<ICommunicationMessage, T> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void On<T1, T2>(Action<ICommunicationMessage, T1, T2> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <typeparam name="T3">The type of the third callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void On<T1, T2, T3>(Action<ICommunicationMessage, T1, T2, T3> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <typeparam name="T3">The type of the third callback parameter.</typeparam>
		/// <typeparam name="T4">The type of the fourth callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void On<T1, T2, T3, T4>(Action<ICommunicationMessage, T1, T2, T3, T4> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <typeparam name="T3">The type of the third callback parameter.</typeparam>
		/// <typeparam name="T4">The type of the fourth callback parameter.</typeparam>
		/// <typeparam name="T5">The type of the fifth callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void On<T1, T2, T3, T4, T5>(Action<ICommunicationMessage, T1, T2, T3, T4, T5> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <param name="callback">The callback.</param>
		void OnRequest(Action<ICommunicationMessage> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T">The type of the first callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void OnRequest<T>(Action<ICommunicationMessage, T> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void OnRequest<T1, T2>(Action<ICommunicationMessage, T1, T2> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <typeparam name="T3">The type of the third callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void OnRequest<T1, T2, T3>(Action<ICommunicationMessage, T1, T2, T3> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <typeparam name="T3">The type of the third callback parameter.</typeparam>
		/// <typeparam name="T4">The type of the fourth callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void OnRequest<T1, T2, T3, T4>(Action<ICommunicationMessage, T1, T2, T3, T4> callback);

		/// <summary>
		/// Registers the specified callback.
		/// </summary>
		/// <typeparam name="T1">The type of the first callback parameter.</typeparam>
		/// <typeparam name="T2">The type of the second callback parameter.</typeparam>
		/// <typeparam name="T3">The type of the third callback parameter.</typeparam>
		/// <typeparam name="T4">The type of the fourth callback parameter.</typeparam>
		/// <typeparam name="T5">The type of the fifth callback parameter.</typeparam>
		/// <param name="callback">The callback.</param>
		void OnRequest<T1, T2, T3, T4, T5>(Action<ICommunicationMessage, T1, T2, T3, T4, T5> callback);
	}
}
