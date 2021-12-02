using System;
using System.Collections.Generic;
using week_7_FootballManager.Entitites.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Name { get; set; }
        public ICollection<Footballer> Footballers { get; set; }
    }
}
