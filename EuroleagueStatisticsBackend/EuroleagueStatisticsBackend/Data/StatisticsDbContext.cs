using EuroleagueStatisticsBackend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EuroleagueStatisticsBackend.Data
{
    public class StatisticsDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerRound> PlayerRounds { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamRound> TeamRounds { get; set; }
        public DbSet<GeneralInformation> GeneralInformation { get; set; }

        public StatisticsDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgreSQL"));
        }
    }
}
