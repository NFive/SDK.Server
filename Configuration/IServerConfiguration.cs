using JetBrains.Annotations;

namespace NFive.SDK.Server.Configuration
{
	[PublicAPI]
	public interface IServerConfiguration
	{
		/// <summary>
		/// Gets the locale.
		/// </summary>
		/// <value>
		/// The locale.
		/// </value>
		ILocaleConfiguration Locale { get; }
	}
}
