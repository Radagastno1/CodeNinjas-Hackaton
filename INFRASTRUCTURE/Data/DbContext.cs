using CORE.Entity;
#nullable disable

namespace INFRASTRUCTURE.Data;

public class DbContext : DbContext
{
    public BioTrananDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<Movie>().HasData(new Movie
        {
        });
    }

    public DbSet<Movie> Movies { get; set; }
}