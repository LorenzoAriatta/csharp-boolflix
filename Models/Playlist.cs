using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int? ProfileId { get; set; }
        public Profile? Profile { get; set; }

        public List<VideoContent>? VideoContents { get; set; }
    }
}