using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_OOP.Formula1.Entities
{
    public class TeamDriver: Driver
    {
        public int Point { get; set; }
        public int CarNo { get; set; }
        public virtual Team Team { get; set; } 
        
    }
}
