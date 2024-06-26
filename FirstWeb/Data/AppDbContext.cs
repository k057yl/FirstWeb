using FirstWeb.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace FirstWeb.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<GroupMember> GroupMembers { get; set; }
    public DbSet<GroupSong> GroupSongs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GroupMember>()
            .HasKey(gm => new { gm.GroupId, gm.MemberId });

        modelBuilder.Entity<GroupSong>()
            .HasKey(gs => new { gs.GroupId, gs.SongId });
    }
}