using System;
using week_7_FootballManager.Entitites.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class Manager : Person, IEntity
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime UpdateDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ManagementPosition ManagementPosition { get; set; }
    }
}
