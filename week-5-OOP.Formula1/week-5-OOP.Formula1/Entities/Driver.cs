﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_5_OOP.Formula1.Entities
{
    public class Driver : IEntity//aktif yarışmayan(takımı olmayan) sürücüler
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
