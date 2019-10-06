namespace NFive.SDK.Server.Configuration
{
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
