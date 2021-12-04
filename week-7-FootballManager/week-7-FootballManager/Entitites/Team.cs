using System;
using System.Collections.Generic;
using week_7_FootballManager.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class Team : IEntity
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public ICollection<Footballer> Footballers { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
