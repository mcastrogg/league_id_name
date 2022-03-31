using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueData.Data.Entities
{
    [Table("league_team", Schema = "historical_lol")]
    public class LeagueTeam 
    {
        [Column("league_team_id")]
        public string LeagueTeamId { get; set; }

        [Column("team_name")]
        public string TeamName { get; set; }

        [Column("team_id")]
        public int? TeamId { get; set; }

        public IEnumerable<LeagueTeamPlayer> LeagueTeamPlayers { get; set; }
    }
}