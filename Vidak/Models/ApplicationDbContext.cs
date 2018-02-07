using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Vidak.Models
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Customer> Customer { get; set; }
		public DbSet<Movie> Movie { get; set; }
		public ApplicationDbContext() : base("Vidak")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}

}