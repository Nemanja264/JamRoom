using Microsoft.EntityFrameworkCore;
using JamRoom.Domain.Entities;

namespace JamRoom.Infrastructure.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Track> Tracks => Set<Track>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Vote> Votes => Set<Vote>();
        public DbSet<User> Users => Set<User>();
        public DbSet<TrackComment> Comments => Set<TrackComment>();


    }
}
