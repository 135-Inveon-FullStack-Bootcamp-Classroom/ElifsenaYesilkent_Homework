using System.Collections.Generic;

namespace week_6_Imdb.Entitites
{
    public class Actor
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual IList<Movie> Movies { get; set; }
    }
}
