using Microsoft.EntityFrameworkCore;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Position> Positions { get; set; } 
        public DbSet<NationalTeam> NationalTeams    { get; set; }
        public DbSet<ManagementPosition> ManagementPositions { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tactic> Tactics { get; set; }
        public DbSet<Manager> Managers { get; set; }
    }

}
