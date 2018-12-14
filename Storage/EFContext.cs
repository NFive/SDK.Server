using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using NFive.SDK.Server.Configuration;
using JetBrains.Annotations;
using MySql.Data.EntityFramework;

namespace NFive.SDK.Server.Storage
{
	/// <inheritdoc />
	/// <summary>
	/// Represents a MySQL Entity Framework database context.
	/// </summary>
	/// <typeparam name="TContext">The type of the database context.</typeparam>
	/// <seealso cref="DbContext" />
	[PublicAPI]
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public abstract class EFContext<TContext> : DbContext where TContext : DbContext
	{
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="EFContext{TContext}"/> class.
		/// </summary>
		static EFContext()
		{
			Database.SetInitializer<TContext>(null);
		}

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="EFContext{TContext}"/> class.
		/// </summary>
		protected EFContext() : base(ServerConfiguration.DatabaseConnection) { }

		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="EFContext{TContext}"/> class.
		/// </summary>
		/// <param name="connectionString">The MySQL database connection string.</param>
		protected EFContext(string connectionString) : base(connectionString) { }

		/// <inheritdoc />
		/// <summary>
		/// This method is called when the model for a derived context has been initialized, but before the model has been locked down and used to initialize the context.
		/// </summary>
		/// <param name="modelBuilder">The builder that defines the model for the context being created.</param>
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			// Store booleans as MySQL BIT type
			modelBuilder.
				Properties<bool>()
				.Configure(c => c.HasColumnType("bit"));

			// Store strings as MySQL VARCHAR type
			modelBuilder
				.Properties()
				.Where(x => x.PropertyType == typeof(string) && !x.GetCustomAttributes(false).OfType<ColumnAttribute>().Any(q => q.TypeName != null && q.TypeName.Equals("varchar", StringComparison.InvariantCultureIgnoreCase)))
				.Configure(c => c.HasColumnType("varchar"));
		}
	}
}
