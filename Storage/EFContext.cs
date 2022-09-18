using System.Linq;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using NFive.SDK.Server.Configuration;

namespace NFive.SDK.Server.Storage
{
	/// <inheritdoc />
	/// <summary>
	/// Represents a MySQL Entity Framework database context.
	/// </summary>
	/// <typeparam name="TContext">The type of the database context.</typeparam>
	[PublicAPI]
	public abstract class EFContext<TContext> : DbContext
		where TContext : DbContext
	{
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="EFContext{TContext}" /> class.
		/// </summary>
		protected EFContext()
			: base(GetOptions(ServerConfiguration.DatabaseConnection))
		{
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="EFContext{TContext}" /> class.
		/// </summary>
		/// <param name="connectionString">The MySQL database connection string.</param>
		protected EFContext(string connectionString)
			: base(GetOptions(connectionString))
		{

		}

		private static DbContextOptions GetOptions(string connectionString)
		{
			return new DbContextOptionsBuilder().UseMySql(connectionString).Options;
		}

		/// <inheritdoc />
		/// <summary>
		/// This method is called when the model for a derived context has been initialized, but before the model has been
		/// locked down and used to initialize the context.
		/// </summary>
		/// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Store booleans as MySQL BIT type
			foreach (var property in modelBuilder.Model.GetEntityTypes()
				         .SelectMany(t => t.GetProperties())
				         .Where(p => p.ClrType == typeof(bool) && p.GetColumnType() == null))
			{
				property.SetColumnType("bit");
			}

			// Store strings as MySQL VARCHAR type
			foreach (var property in modelBuilder.Model.GetEntityTypes()
				         .SelectMany(t => t.GetProperties())
				         .Where(p => p.ClrType == typeof(string) && p.GetColumnType() == null))
			{
				property.SetIsUnicode(false);
			}
		}
	}
}
