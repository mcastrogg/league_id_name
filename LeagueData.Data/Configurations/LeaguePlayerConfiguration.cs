using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsGenerationService.Data.Constants;

namespace LeagueData.Data.Configurations;

public class LeaguePlayerConfiguration : IEntityTypeConfiguration<LeaguePlayer>
{
    public void Configure(EntityTypeBuilder<LeaguePlayer> builder)
    {
        builder.ToTable("league_player", DatabaseConstants.HistoricalLolSchema);
        builder.HasKey(x => x.LeaguePlayerId);
    }
    
}