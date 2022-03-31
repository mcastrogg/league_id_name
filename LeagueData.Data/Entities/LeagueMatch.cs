using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueData.Data.Entities
{
    [Table("league_matches", Schema = "historical_lol")]
    public class LeagueMatch
    {
        [Column("match_id")]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int MatchId { get; set; }

        [Column("game_id")]
        public string GameId { get; set; }

        [Column("datacompleteness")]
        public string DataCompleteness { get; set; }

        [Column("url")]
        public string Url { get; set; }

        [Column("league")]
        public string League { get; set; }

        [Column("year")]
        public int Year { get; set; }

        [Column("split")]
        public string Split { get; set; }

        [Column("playoffs")]
        public int Playoffs { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("game")]
        public int Game { get; set; }

        [Column("patch")]
        public string Patch { get; set; }

        [Column("gamelength")]
        public int GameLength { get; set; }

        public ICollection<LeaguePlayerMatch> PlayerMatches { get; set; }
        public ICollection<LeagueTeamMatch> LeagueTeamMatches { get; set; }
    }
}