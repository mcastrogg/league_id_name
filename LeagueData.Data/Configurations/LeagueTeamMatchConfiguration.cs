using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsGenerationService.Data.Constants;

namespace LeagueData.Data.Configurations;

public class LeagueTeamMatchConfiguration : IEntityTypeConfiguration<LeagueTeamMatch>
{
    public void Configure(EntityTypeBuilder<LeagueTeamMatch> builder)
    {
        builder.ToTable("league_team_matches", DatabaseConstants.HistoricalLolSchema);
        
        builder.HasKey(x => x.TeamMatchId);

        // builder.HasOne(x => x.LeagueTeam)
        //     .WithMany(x => x.LeagueTeamMatches)
        //     .HasPrincipalKey(x => x.TeamName)
        //     .HasForeignKey(x => x.TeamName);
    }
    
}