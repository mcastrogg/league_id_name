namespace LeagueData.Entities;

public class OeEntity
{
    
    [CsvHelper.Configuration.Attributes.Name("playername")]
    public string PlayerName { get; set; }
    [CsvHelper.Configuration.Attributes.Name("teamname")]
    public string TeamName { get; set; }
    [CsvHelper.Configuration.Attributes.Name("playerid")]
    public string PlayerId { get; set; }
    [CsvHelper.Configuration.Attributes.Name("teamid")]
    public string TeamId { get; set; }
}