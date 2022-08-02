using csharp_boolflix.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Data
{
    public class BoolflixContext : DbContext
    {
        public DbSet<VideoContent> VideoContents { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Playlist> Playlists { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=db-boolflix;Integrated Security=True");
        }
    }

}