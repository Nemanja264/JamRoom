namespace JamRoom.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public required string Nickname { get; set; }
    }
}
