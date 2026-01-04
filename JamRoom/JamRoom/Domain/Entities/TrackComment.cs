namespace JamRoom.Domain.Entities
{
    public class TrackComment
    {
        public int Id { get; set; }
        public int TrackId { get; set; }
        public Guid UserId { get; set; }

        public string Comment { get; set; } = "";
    }
}
