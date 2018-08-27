using NFive.SDK.Core.Diagnostics;

namespace NFive.SDK.Server.Configuration
{
	public static class ServerConfiguration
	{
		public static LogLevel LogLevel { get; set; } = LogLevel.Debug;

		public static string DatabaseConnection { get; set; } = "Host=localhost";

		public static bool AutomaticMigrations { get; set; }
	}
}
