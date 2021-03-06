using System.Collections.Generic;

namespace week_6_Imdb.Entitites
{
    public class Movie
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public virtual IList<Actor> Actors { get; set; }
    }
}
