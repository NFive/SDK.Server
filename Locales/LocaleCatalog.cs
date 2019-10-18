using System.Globalization;
using NFive.SDK.Core.Locales;
using NGettext;

namespace NFive.SDK.Server.Locales
{
	public class LocaleCatalog : ILocaleCatalog
	{
		private readonly Catalog catalog;

		public LocaleCatalog(Catalog catalog)
		{
			this.catalog = catalog;
		}

		public CultureInfo Culture => this.catalog.CultureInfo;

		public string GetString(string text) => this.catalog.GetString(text);

		public string GetString(string text, params object[] args) => this.catalog.GetString(text, args);

		public string GetPluralString(string text, string pluralText, long n) => this.catalog.GetPluralString(text, pluralText, n);

		public string GetPluralString(string text, string pluralText, long n, params object[] args) => this.catalog.GetPluralString(text, pluralText, n, args);

		public string GetParticularString(string context, string text) => this.catalog.GetParticularString(context, text);

		public string GetParticularString(string context, string text, params object[] args) => this.catalog.GetParticularString(context, text, args);

		public string GetParticularPluralString(string context, string text, string pluralText, long n) => this.catalog.GetParticularPluralString(context, text, pluralText, n);

		public string GetParticularPluralString(string context, string text, string pluralText, long n, params object[] args) => this.catalog.GetParticularPluralString(context, text, pluralText, n, args);
	}
}
