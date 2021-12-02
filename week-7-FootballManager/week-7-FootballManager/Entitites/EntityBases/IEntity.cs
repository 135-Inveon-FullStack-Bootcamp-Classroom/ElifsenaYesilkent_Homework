using System;

namespace week_7_FootballManager.Entitites.EntityBases
{
    public interface IEntity
    {
        int Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
