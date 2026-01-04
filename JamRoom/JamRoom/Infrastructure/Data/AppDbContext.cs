using Microsoft.EntityFrameworkCore;
using JamRoom.Domain.Entities;

namespace JamRoom.Infrastructure.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Track> Tracks => Set<Track>();
        public DbSet<Playlist> Playlists => Set<Playlist>();
        public DbSet<Vote> Votes => Set<Vote>();
    }
}
