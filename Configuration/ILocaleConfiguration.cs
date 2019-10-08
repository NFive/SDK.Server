using System;
using System.Globalization;
using JetBrains.Annotations;

namespace NFive.SDK.Server.Configuration
{
	[PublicAPI]
	public interface ILocaleConfiguration
	{
		/// <summary>
		/// Gets or sets the culture.
		/// </summary>
		/// <value>
		/// The culture.
		/// </value>
		CultureInfo Culture { get; set; }

		/// <summary>
		/// Gets or sets the time zone.
		/// </summary>
		/// <value>
		/// The time zone.
		/// </value>
		TimeZoneInfo TimeZone { get; set; }
	}
}
