using System;
using week_7_FootballManager.Entitites.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class Team:IEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
