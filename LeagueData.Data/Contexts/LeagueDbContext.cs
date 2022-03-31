using LeagueData.Data.Configurations;
using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LeagueData.Data.Contexts
{
    public class LeagueDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Host=main-us-e2.cmbsiiqeauby.us-east-2.rds.amazonaws.com;Port=5432;User ID=doadmin;Password=i39kew8n7jcat7l9;Database=main;");
        
        // public DbSet<LeagueMatch> LeagueMatches { get; set; }
        public DbSet<LeaguePlayer> LeaguePlayers { get; set; }
        // public DbSet<LeaguePlayerMatch> LeaguePlayerMatches { get; set; }
        // public DbSet<LeagueTeamMatch> LeagueTeamMatches { get; set; }
        public DbSet<LeagueTeam> LeagueTeams { get; set; }
        public DbSet<LeagueTeamPlayer?> LeagueTeamPlayers { get; set; }
        
        
        // public DbSet<Video_game> VideoGames { get; set; }
        //
        // public DbSet<Match> Matches { get; set; }
        // public DbSet<Game> Games { get; set; }
        // public DbSet<MatchOpponent> MatchOpponents { get; set; }
        // public DbSet<MatchResult> MatchResults { get; set; }

        // public DbSet<MarketType> MarketTypes { get; set; }
        // public DbSet<MarketSide> MarketSides { get; set; }
        // public DbSet<MarketSideOdds> MarketSideOdds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LeagueTeamConfiguration());
            modelBuilder.ApplyConfiguration(new LeaguePlayerConfiguration());
            // modelBuilder.ApplyConfiguration(new LeagueMatchConfiguration());
            // modelBuilder.ApplyConfiguration(new LeaguePlayerMatchConfiguration());
            // modelBuilder.ApplyConfiguration(new LeagueTeamMatchConfiguration());
            modelBuilder.ApplyConfiguration(new LeagueTeamPlayerConfiguration());
            
            // modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            // modelBuilder.ApplyConfiguration(new MatchResultConfiguration());
        }
    }
}