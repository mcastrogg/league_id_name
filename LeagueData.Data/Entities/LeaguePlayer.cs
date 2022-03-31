using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueData.Data.Entities
{
    [Table("league_player", Schema = "historical_lol")]
    public class LeaguePlayer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [Column("league_player_id")] 
        public string LeaguePlayerId { get; set; }

        [Column("player_id")] 
        public int? PlayerId { get; set; }

        [Column("player_name")] 
        public string PlayerName { get; set; }
        public IEnumerable<LeagueTeamPlayer> LeagueTeamPlayers { get; set; }
    }
}