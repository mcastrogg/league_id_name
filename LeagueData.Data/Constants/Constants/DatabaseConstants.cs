
namespace OddsGenerationService.Data.Constants
{
    public static class DatabaseConstants
    {
        public const string FixtureSchema = "fixture";
        public const string MarketSchema = "markets";
        public const string UserSchema = "user";
        public const string HistoricalLolSchema = "historical_lol";

        public static class SQLFilePaths
        {
            public const string LeaguePlayerAveragesFileName = "LeaguePlayerAverages.sql";
            public const string LeaguePositionAveragesFileName = "LeaguePositionAverageByLeague.sql";
        }

        public const int LastNMatches = 20;
    }
}