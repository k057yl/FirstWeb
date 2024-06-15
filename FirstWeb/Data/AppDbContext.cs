using FirstWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWeb.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Pet> Pets { get; set; }
    public DbSet<Food> Foods { get; set; }
    
    /*
    public DbSet<Band> Bands { get; set; }
    public DbSet<Song> Songs { get; set; }
    */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
        modelBuilder.Entity<Band>()
            .HasMany(b => b.Songs)
            .WithOne(s => s.Band)
            .HasForeignKey(s => s.BandId);

        base.OnModelCreating(modelBuilder);
        */
    }
}