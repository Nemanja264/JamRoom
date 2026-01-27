using Microsoft.EntityFrameworkCore;
using JamRoom.Domain.Entities;

namespace JamRoom.Infrastructure.Data
{
    public class JamRoomDbContext:DbContext
    {
        public JamRoomDbContext(DbContextOptions<JamRoomDbContext> options) : base(options) { }

        public DbSet<Track> Tracks => Set<Track>();
        public DbSet<Room> Rooms => Set<Room>();
        public DbSet<Vote> Votes => Set<Vote>();
        public DbSet<User> Users => Set<User>();
        public DbSet<TrackComment> Comments => Set<TrackComment>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Vote>()
                .HasKey(v => new { v.TrackId, v.UserId });

            modelBuilder.Entity<TrackComment>()
               .HasOne(c => c.Track)
               .WithMany(t => t.Comments)
               .HasForeignKey(c => c.TrackId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<TrackComment>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Vote>()
                .HasOne(v => v.User)
                .WithMany()
                .HasForeignKey(v => v.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Vote>()
               .HasOne(v => v.Track)
               .WithMany(t => t.Likes)
               .HasForeignKey(v => v.TrackId)
               .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
