using System;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.EntityBases
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Team Team { get; set; }
        public NationalTeam NationalTeam { get; set; }
    }
}
