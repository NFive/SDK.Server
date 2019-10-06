using System;
using System.Globalization;

namespace NFive.SDK.Server.Configuration
{
	public interface ILocaleConfiguration
	{
		CultureInfo Culture { get; set; }

		TimeZoneInfo TimeZone { get; set; }
	}
}
