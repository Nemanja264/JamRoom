namespace JamRoom.Domain.Entities
{
    public class TrackComment
    {
        public Guid Id { get; set; }
        public Guid TrackId { get; set; }
        public Track Track { get; set; } = default!;
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;

        public string Comment { get; set; } = "";
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
