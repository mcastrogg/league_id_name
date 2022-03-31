using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OddsGenerationService.Data.Constants;

namespace LeagueData.Data.Configurations;

public class LeagueTeamPlayerConfiguration : IEntityTypeConfiguration<LeagueTeamPlayer>
{
    public void Configure(EntityTypeBuilder<LeagueTeamPlayer> builder)
    {
        builder.ToTable("league_team_player", DatabaseConstants.HistoricalLolSchema);

        builder.HasKey(x => x.Id);
        
        builder.HasIndex(x => new {x.LeagueTeamId, x.LeaguePlayerId}).IsUnique();

        builder.HasOne(x => x.LeaguePlayer)
            .WithMany(x => x.LeagueTeamPlayers)
            .HasPrincipalKey(x => x.LeaguePlayerId)
            .HasForeignKey(x => x.LeaguePlayerId);

        builder.HasOne(x => x.LeagueTeam)
            .WithMany(x => x.LeagueTeamPlayers)
            .HasPrincipalKey(x => x.LeagueTeamId)
            .HasForeignKey(x => x.LeagueTeamId);

    }
}