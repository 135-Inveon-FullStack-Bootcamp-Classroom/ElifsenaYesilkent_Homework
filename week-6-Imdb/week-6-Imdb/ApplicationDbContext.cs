﻿using Microsoft.EntityFrameworkCore;
using week_6_Imdb.Entitites;

namespace week_6_Imdb
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Movies> Movies { get; set; }
    }
}