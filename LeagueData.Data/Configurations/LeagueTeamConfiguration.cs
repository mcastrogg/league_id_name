using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsGenerationService.Data.Constants;

namespace LeagueData.Data.Configurations;

public class LeagueTeamConfiguration : IEntityTypeConfiguration<LeagueTeam>
{
    public void Configure(EntityTypeBuilder<LeagueTeam> builder)
    {
        builder.ToTable("league_team", DatabaseConstants.HistoricalLolSchema);
        builder.HasKey(x => x.LeagueTeamId);

        // builder.Ignore(x => x.LeagueTeamMatches);
    }
}