using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        public bool IsUnderage { get; set; }

        public Playlist? Playlist { get; set; }

        public List<VideoContent>? VideoContents { get; set; }

    }
}
