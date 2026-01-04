using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace JamRoom.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public required string UserId { get; set; }
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
