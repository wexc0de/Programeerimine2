
using Microsoft.EntityFrameworkCore;

namespace KooliProjekt.Application.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(
			DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<user> Users { get; set; }
		public DbSet<task> Tasks { get; set; }
		public DbSet<project> Projects { get; set; }
		public DbSet<logs> Logs { get; set; }
	}
}
