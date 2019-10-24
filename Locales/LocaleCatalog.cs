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

		public string _(string text) => this.GetString(text);

		public string GetString(string text, params object[] args) => this.catalog.GetString(text, args);

		public string _(string text, params object[] args) => this.GetString(text);

		public string GetPluralString(string text, string pluralText, long n) => this.catalog.GetPluralString(text, pluralText, n);

		public string _n(string text, string pluralText, long n) => this.GetPluralString(text, pluralText, n);

		public string GetPluralString(string text, string pluralText, long n, params object[] args) => this.catalog.GetPluralString(text, pluralText, n, args);

		public string _n(string text, string pluralText, long n, params object[] args) => this.GetPluralString(text, pluralText, n);

		public string GetParticularString(string context, string text) => this.catalog.GetParticularString(context, text);

		public string _p(string context, string text) => this.GetParticularString(context, text);

		public string GetParticularString(string context, string text, params object[] args) => this.catalog.GetParticularString(context, text, args);

		public string _p(string context, string text, params object[] args) => this.GetParticularString(context, text);

		public string GetParticularPluralString(string context, string text, string pluralText, long n) => this.catalog.GetParticularPluralString(context, text, pluralText, n);

		public string _pn(string context, string text, string pluralText, long n) => this.GetParticularPluralString(context, text, pluralText, n);

		public string GetParticularPluralString(string context, string text, string pluralText, long n, params object[] args) => this.catalog.GetParticularPluralString(context, text, pluralText, n, args);

		public string _pn(string context, string text, string pluralText, long n, params object[] args) => this.GetParticularPluralString(context, text, pluralText, n);
	}
}
