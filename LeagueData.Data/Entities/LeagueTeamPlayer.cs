using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueData.Data.Entities
{
    [Table("league_team_player", Schema = "historical_lol")]
    public class LeagueTeamPlayer
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("team_name")]
        public string TeamName { get; set; }

        [Column("player_name")]
        public string PlayerName { get; set; }
        
        [Column("league_player_id")]
        public string LeaguePlayerId { get; set; }
        
        [Column("league_team_id")]
        public string LeagueTeamId { get; set; }

        public LeaguePlayer LeaguePlayer { get; set; }
        public LeagueTeam LeagueTeam { get; set; }
    }
}