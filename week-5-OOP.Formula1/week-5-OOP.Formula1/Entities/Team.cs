using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_OOP.Formula1.Entities
{
    public class Team : IEntity//temel sınıftan alınan özellikler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EngineName { get; set; }  
        public  int Point { get; set; }
    }
}
