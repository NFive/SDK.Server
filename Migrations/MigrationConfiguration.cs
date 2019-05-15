using JetBrains.Annotations;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace NFive.SDK.Server.Migrations
{
	/// <inheritdoc />
	/// <summary>
	/// Configuration relating to the use of migrations for a given database model.
	/// </summary>
	/// <typeparam name="TContext">The type of the database context.</typeparam>
	[PublicAPI]
	public abstract class MigrationConfiguration<TContext> : DbMigrationsConfiguration<TContext> where TContext : DbContext
	{
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="MigrationConfiguration{TContext}" /> class.
		/// </summary>
		protected MigrationConfiguration()
		{
			this.AutomaticMigrationsEnabled = false;
			this.AutomaticMigrationDataLossAllowed = false;
		}

		/// <inheritdoc />
		/// <summary>
		/// Runs after upgrading to the latest migration to allow seed data to be updated.
		/// </summary>
		/// <param name="context">Context to be used for updating seed data.</param>
		protected override void Seed(TContext context) { }
	}
}
