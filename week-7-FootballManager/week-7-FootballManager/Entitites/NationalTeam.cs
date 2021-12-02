using System;
using week_7_FootballManager.Entitites.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class NationalTeam : Team, IEntity
    {
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
