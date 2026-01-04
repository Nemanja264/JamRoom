using System.ComponentModel.DataAnnotations;

namespace JamRoom.Domain.Entities
{
    public class Track
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        
        public required string Url { get; set; }
        public string Author { get; set; } = "";
        public ICollection<Vote> Likes { get; set; } = new List<Vote>();
    }
}
