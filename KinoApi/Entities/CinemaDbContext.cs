using Microsoft.EntityFrameworkCore;

namespace KinoApi.Entities
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(DbContextOptions<CinemaDbContext> options): base(options)
        {
        }
        public DbSet<Cinema> Cinema { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
