using System.ComponentModel.DataAnnotations.Schema;

namespace LeagueData.Data.Entities
{
    [Table("league_team_matches", Schema = "historical_lol")]
    public class LeagueTeamMatch
    {
        
        [Column("match_id")]
        public int MatchId { get; set; }

        [Column("team_match_id")]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int TeamMatchId { get; set; }

        [Column("won")]
        public int Won { get; set; }

        [Column("team")]
        public string Team { get; set; }
        
        [Column("team_name")]
        public string TeamName { get; set; }

        [Column("side")]
        public string Side { get; set; }

        [Column("kills")]
        public int? Kills { get; set; }

        [Column("deaths")]
        public int? Deaths { get; set; }

        [Column("assists")]
        public int? Assists { get; set; }

        [Column("teamkills")]
        public int? TeamKills { get; set; }

        [Column("teamdeaths")]
        public int? TeamDeaths { get; set; }

        [Column("doublekills")]
        public int? DoubleKills { get; set; }

        [Column("triplekills")]
        public int? TripleKills { get; set; }

        [Column("quadrakills")]
        public int? QuadraKills { get; set; }

        [Column("pentakills")]
        public int? PentaKills { get; set; }

        [Column("firstblood")]
        public int? FirstBlood { get; set; }

        [Column("firstbloodkill")]
        public int? FirstBloodKill { get; set; }

        [Column("firstbloodassist")]
        public int? FirstBloodAssist { get; set; }

        [Column("firstbloodvictim")]
        public int? FirstBloodVictim { get; set; }

        [Column("team_kpm")]
        public float? TeamKpm { get; set; }

        [Column("ckpm")]
        public float? Ckpm { get; set; }

        [Column("firstdragon")]
        public int? FirstDragon { get; set; }

        [Column("opp_dragons")]
        public int? OppDragons { get; set; }

        [Column("elementaldrakes")]
        public int? ElementalDrakes { get; set; }

        [Column("opp_elementaldrakes")]
        public int? OppElementalDrakes { get; set; }

        [Column("infernals")]
        public int? Infernals { get; set; }

        [Column("mountains")]
        public int? Mountains { get; set; }

        [Column("clouds")]
        public int? Clouds { get; set; }

        [Column("oceans")]
        public int? Oceans { get; set; }

        [Column("dragons_unknown")]
        public int? DragonsUnknown { get; set; }

        [Column("elders")]
        public int? Elders { get; set; }

        [Column("opp_elders")]
        public int? OppElders { get; set; }

        [Column("firstherald")]
        public int? FirstHerald { get; set; }

        [Column("heralds")]
        public int? Heralds { get; set; }

        [Column("firstbaron")]
        public int? FirstBaron { get; set; }

        [Column("barons")]
        public int? Barons { get; set; }

        [Column("opp_barons")]
        public int? OppBarons { get; set; }

        [Column("firsttower")]
        public int? FirstTower { get; set; }

        [Column("towers")]
        public int? Towers { get; set; }

        [Column("opp_towers")]
        public int? OppTowers { get; set; }

        [Column("firstmidtower")]
        public int? FirstMidTower { get; set; }

        [Column("firsttothreetowers")]
        public int? FirstToThreeTowers { get; set; }

        [Column("inhibitors")]
        public int? Inhibitors { get; set; }

        [Column("opp_inhibitors")]
        public int? OppInhibitors { get; set; }

        [Column("damagetochampions")]
        public int? DamageToChampions { get; set; }

        [Column("dpm")]
        public float? Dpm { get; set; }

        [Column("damageshare")]
        public float? DamageShare { get; set; }

        [Column("damagetakenperminute")]
        public float? DamageTakenPerMinute { get; set; }

        [Column("damagemitigatedperminute")]
        public float? DamageMitigatedPerMinute { get; set; }

        [Column("wardsplaced")]
        public int? WardsPlaced { get; set; }

        [Column("wpm")]
        public float? Wpm { get; set; }

        [Column("wardskilled")]
        public int? WardsKilled { get; set; }

        [Column("wcpm")]
        public float? Wcpm { get; set; }

        [Column("controlwardsbought")]
        public int? ControlWardsBought { get; set; }

        [Column("visionscore")]
        public float? VisionScore { get; set; }

        [Column("vspm")]
        public float? Vspm { get; set; }

        [Column("totalgold")]
        public int? TotalGold { get; set; }

        [Column("earnedgold")]
        public int? EarnedGold { get; set; }

        [Column("earned_gpm")]
        public float? EarnedGpm { get; set; }

        [Column("earnedgoldshare")]
        public float? EarnedGoldShare { get; set; }

        [Column("goldspent")]
        public int? GoldSpent { get; set; }

        [Column("gspd")]
        public float? Gspd { get; set; }

        [Column("total_cs")]
        public int? TotalCs { get; set; }

        [Column("minionkills")]
        public int? MinionKills { get; set; }

        [Column("monsterkills")]
        public int? MonsterKills { get; set; }

        [Column("monsterkillsownjungle")]
        public int? MonsterKillsOwnJungle { get; set; }

        [Column("monsterkillsenemyjungle")]
        public int? MonsterKillsEnemyJungle { get; set; }

        [Column("cspm")]
        public float? Cspm { get; set; }

        [Column("goldat10")]
        public int? GoldAt10 { get; set; }

        [Column("xpat10")]
        public int? XpAt10 { get; set; }

        [Column("csat10")]
        public int? CsAt10 { get; set; }

        [Column("opp_goldat10")]
        public int? OppGoldAt10 { get; set; }

        [Column("opp_xpat10")]
        public int? OppXpAt10 { get; set; }

        [Column("opp_csat10")]
        public int? OppCsAt10 { get; set; }

        [Column("golddiffat10")]
        public int? GoldDiffAt10 { get; set; }

        [Column("xpdiffat10")]
        public int? XpDiffAt10 { get; set; }

        [Column("csdiffat10")]
        public int? CsDiffAt10 { get; set; }

        [Column("killsat10")]
        public int? KillsAt10 { get; set; }

        [Column("assistsat10")]
        public int? AssistsAt10 { get; set; }

        [Column("deathsat10")]
        public int? DeathsAt10 { get; set; }

        [Column("opp_killsat10")]
        public int? OppKillsAt10 { get; set; }

        [Column("opp_assistsat10")]
        public int? OppAssistsAt10 { get; set; }

        [Column("opp_deathsat10")]
        public int? OppDeathsAt10 { get; set; }

        [Column("goldat15")]
        public int? GoldAt15 { get; set; }

        [Column("xpat15")]
        public int? XpAt15 { get; set; }

        [Column("csat15")]
        public int? CsAt15 { get; set; }

        [Column("opp_goldat15")]
        public int? OppGoldAt15 { get; set; }

        [Column("opp_xpat15")]
        public int? OppXpAt15 { get; set; }

        [Column("opp_csat15")]
        public int? OppCsAt15 { get; set; }

        [Column("golddiffat15")]
        public int? GoldDiffAt15 { get; set; }

        [Column("xpdiffat15")]
        public int? XpDiffAt15 { get; set; }

        [Column("csdiffat15")]
        public int? CsDiffAt15 { get; set; }

        [Column("killsat15")]
        public int? KillsAt15 { get; set; }

        [Column("assistsat15")]
        public int? AssistsAt15 { get; set; }

        [Column("deathsat15")]
        public int? DeathsAt15 { get; set; }

        [Column("opp_killsat15")]
        public int? OppKillsAt15 { get; set; }

        [Column("opp_assistsat15")]
        public int? OppAssistsAt15 { get; set; }

        [Column("opp_deathsat15")]
        public int? OppDeathsAt15 { get; set; }

        public LeagueMatch LeagueMatch { get; set; }

        public LeagueTeam LeagueTeam { get; set; }
    }
}