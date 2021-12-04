﻿using System;
using week_7_FootballManager.EntityBases;

namespace week_7_FootballManager.Entitites
{
    public class Manager : Person, IEntity
    {
        public ManagementPosition ManagementPosition { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
