using CORE.Entities;
#nullable disable

namespace INFRASTRUCTURE.Data;

public class DbContext : DbContext
{
    public DbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Movie>().HasData(new Movie
        {
        });
    }

    public DbSet<Movie> Movies { get; set; }
}