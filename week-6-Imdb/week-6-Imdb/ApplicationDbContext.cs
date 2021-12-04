using Microsoft.EntityFrameworkCore;
using week_6_Imdb.Entitites;

namespace week_6_Imdb
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Award> Awards { get; set; }
    }
}
