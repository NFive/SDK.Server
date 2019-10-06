using JetBrains.Annotations;
using System;
using System.Threading.Tasks;

namespace NFive.SDK.Server.Communications
{
	[PublicAPI]
	public interface ICommunicationTransmit
	{
		/// <summary>
		/// Emits the specified payloads.
		/// </summary>
		/// <param name="payloads">The payloads.</param>
		void Emit(params object[] payloads);

		/// <summary>
		/// Requests the specified type with the specified parameters.
		/// </summary>
		/// <typeparam name="TReturn">The type of the return.</typeparam>
		/// <param name="payloads">The payloads.</param>
		/// <returns></returns>
		Task<TReturn> Request<TReturn>(params object[] payloads);

		/// <summary>
		/// Requests the specified types with the specified parameters.
		/// </summary>
		/// <typeparam name="TReturn1">The type of the return1.</typeparam>
		/// <typeparam name="TReturn2">The type of the return2.</typeparam>
		/// <param name="payloads">The payloads.</param>
		/// <returns>The requested types.</returns>
		Task<Tuple<TReturn1, TReturn2>> Request<TReturn1, TReturn2>(params object[] payloads);

		/// <summary>
		/// Requests the specified types with the specified parameters.
		/// </summary>
		/// <typeparam name="TReturn1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn2">The type of the 2.</typeparam>
		/// <typeparam name="TReturn3">The type of the 3.</typeparam>
		/// <param name="payloads">The payloads.</param>
		/// <returns>The requested types.</returns>
		Task<Tuple<TReturn1, TReturn2, TReturn3>> Request<TReturn1, TReturn2, TReturn3>(params object[] payloads);

		/// <summary>
		/// Requests the specified types with the specified parameters.
		/// </summary>
		/// <typeparam name="TReturn1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn2">The type of the 2.</typeparam>
		/// <typeparam name="TReturn3">The type of the 3.</typeparam>
		/// <typeparam name="TReturn4">The type of the 4.</typeparam>
		/// <param name="payloads">The payloads.</param>
		/// <returns>The requested types.</returns>
		Task<Tuple<TReturn1, TReturn2, TReturn3, TReturn4>> Request<TReturn1, TReturn2, TReturn3, TReturn4>(params object[] payloads);

		/// <summary>
		/// Requests the specified types with the specified parameters.
		/// </summary>
		/// <typeparam name="TReturn1">The type of the 1.</typeparam>
		/// <typeparam name="TReturn2">The type of the 2.</typeparam>
		/// <typeparam name="TReturn3">The type of the 3.</typeparam>
		/// <typeparam name="TReturn4">The type of the 4.</typeparam>
		/// <typeparam name="TReturn5">The type of the 5.</typeparam>
		/// <param name="payloads">The payloads.</param>
		/// <returns>The requested types.</returns>
		Task<Tuple<TReturn1, TReturn2, TReturn3, TReturn4, TReturn5>> Request<TReturn1, TReturn2, TReturn3, TReturn4, TReturn5>(params object[] payloads);

	}
}
