using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsGenerationService.Data.Constants;

namespace LeagueData.Data.Configurations;

public class LeagueMatchConfiguration : IEntityTypeConfiguration<LeagueMatch>
{
    public void Configure(EntityTypeBuilder<LeagueMatch> builder)
    {
        builder.ToTable("league_matches", DatabaseConstants.HistoricalLolSchema);
        builder.HasKey(x => x.MatchId);

        builder.HasMany(x => x.PlayerMatches)
            .WithOne(x => x.LeagueMatch)
            .HasForeignKey(x => x.MatchId);

        // builder.HasMany(x => x.LeagueTeamMatches)
        //     .WithOne(x => x.LeagueMatch)
        //     .HasForeignKey(x => x.MatchId);
        builder.Ignore(x => x.LeagueTeamMatches);
    }
}