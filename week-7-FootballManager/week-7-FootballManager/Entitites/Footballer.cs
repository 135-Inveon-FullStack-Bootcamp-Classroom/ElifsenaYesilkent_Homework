using System;
using System.Collections.Generic;
using week_7_FootballManager.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class Footballer:Person,IEntity
    {  
        public int Id { get; set; }
        //public ICollection<Position> Positions { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
