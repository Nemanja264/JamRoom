namespace JamRoom.Domain.Entities
{
    public class Room
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public Guid OwnerUserId { get; set; }
        public User OwnerUser { get; set; } = default!;
        public ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
