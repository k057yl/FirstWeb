using FirstWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWeb.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Band> Bands { get; set; }
    public DbSet<Song> Songs { get; set; }
}