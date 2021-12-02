using System;
using System.Collections.Generic;
using week_7_FootballManager.Entitites.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class Coach : Person, IEntity
    {
        public ICollection<Tactic> Tactics { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
      
    }
}
