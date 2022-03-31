using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsGenerationService.Data.Constants;

namespace LeagueData.Data.Configurations;

public class LeaguePlayerMatchConfiguration : IEntityTypeConfiguration<LeaguePlayerMatch>
{
    public void Configure(EntityTypeBuilder<LeaguePlayerMatch> builder)
    {
        builder.ToTable("league_player_matches", DatabaseConstants.HistoricalLolSchema);
        
        builder.HasKey(x => x.PlayerMatchId);
        
        builder.HasIndex(x => new {x.MatchId, x.PlayerName, x.Team}).IsUnique();
        
        // builder.HasOne(x => x.LeagueTeamPlayer)
        //     .WithMany(x => x.LeaguePlayerMatches)
        //     .HasPrincipalKey(x => new {x.PlayerName, x.TeamName})
        //     .HasForeignKey(x => new {x.PlayerName, x.Team});

        // builder.Ignore(x => x.LeagueMatch);
        

        builder.Property(x => x.GoldAt10).HasColumnName("goldat10");
        builder.Property(x => x.CsAt10).HasColumnName("csat10");
        builder.Property(x => x.XpAt10).HasColumnName("xpat10");
        builder.Property(x => x.OppGoldAt10).HasColumnName("opp_goldat10");
        builder.Property(x => x.OppCsAt10).HasColumnName("opp_csat10");
        builder.Property(x => x.OppXpAt10).HasColumnName("opp_xpat10");
        builder.Property(x => x.GoldDiffAt10).HasColumnName("golddiffat10");
        builder.Property(x => x.CsDiffAt10).HasColumnName("csdiffat10");
        builder.Property(x => x.XpDiffAt10).HasColumnName("xpdiffat10");
        builder.Property(x => x.KillsAt10).HasColumnName("killsat10");
        builder.Property(x => x.AssistsAt10).HasColumnName("assistsat10");
        builder.Property(x => x.DeathsAt10).HasColumnName("deathsat10");
        builder.Property(x => x.OppKillsAt10).HasColumnName("opp_killsat10");
        builder.Property(x => x.OppAssistsAt10).HasColumnName("opp_assistsat10");
        builder.Property(x => x.OppDeathsAt10).HasColumnName("opp_deathsat10");
        
        builder.Property(x => x.GoldAt15).HasColumnName("goldat15");
        builder.Property(x => x.CsAt15).HasColumnName("csat15");
        builder.Property(x => x.XpAt15).HasColumnName("xpat15");
        builder.Property(x => x.OppGoldAt15).HasColumnName("opp_goldat15");
        builder.Property(x => x.OppCsAt15).HasColumnName("opp_csat15");
        builder.Property(x => x.OppXpAt15).HasColumnName("opp_xpat15");
        builder.Property(x => x.GoldDiffAt15).HasColumnName("golddiffat15");
        builder.Property(x => x.CsDiffAt15).HasColumnName("csdiffat15");
        builder.Property(x => x.XpDiffAt15).HasColumnName("xpdiffat15");
        builder.Property(x => x.KillsAt15).HasColumnName("killsat15");
        builder.Property(x => x.AssistsAt15).HasColumnName("assistsat15");
        builder.Property(x => x.DeathsAt15).HasColumnName("deathsat15");
        builder.Property(x => x.OppKillsAt15).HasColumnName("opp_killsat15");
        builder.Property(x => x.OppAssistsAt15).HasColumnName("opp_assistsat15");
        builder.Property(x => x.OppDeathsAt15).HasColumnName("opp_deathsat15");
        
        
    }
    
}