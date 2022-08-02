using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class VideoContent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Duration { get; set; }

        public string Type { get; set; }

        public string? CoverImage { get; set; }

        public string? Description { get; set; }

        public List<Playlist>? Playlists { get; set; }

        public List<Profile>? Profiles { get; set; }

        public List<Genre>? Genres { get; set; }
    }
}
