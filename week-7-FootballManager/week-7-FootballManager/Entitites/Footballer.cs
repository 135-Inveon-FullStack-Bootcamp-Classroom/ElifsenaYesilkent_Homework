using System;
using System.Collections.Generic;

namespace week_7_FootballManager.Entitites
{
    public class Footballer
    {
        public ICollection<Position> Positions { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
