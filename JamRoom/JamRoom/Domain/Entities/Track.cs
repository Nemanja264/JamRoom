using System.ComponentModel.DataAnnotations;

namespace JamRoom.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        [Required]
        public string Url { get; set; } = "";
        public string Author { get; set; } = "";
        public ICollection<Vote> Likes { get; set; } = new List<Vote>();
    }
}
