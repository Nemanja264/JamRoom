using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace JamRoom.Domain.Entities
{
    public class Vote
    {
        public Guid TrackId { get; set; }
        public Track Track { get; set; } = default!;
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
