using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using scamp.Models;

namespace scamp.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		// Add a DbSet for each entity of the application
		public DbSet<Utilizador> Utilizador { get; set;}
		public DbSet<Curso> Curso { get; set;}
		public DbSet<Post> Post { get; set; }
		public DbSet<Comentario> Comentario { get; set; }
		public DbSet<Like> Like { get; set; }

	}
}
