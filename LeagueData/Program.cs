// See https://aka.ms/new-console-template for more information

using LeagueData;
using LeagueData.Data.Contexts;
using LeagueData.Data.Repositories;

Console.WriteLine("Hello, World!");

var oeEntities = CSVReader.ReadInCSV();
var context = new LeagueDbContext();
var repository = new LeagueRepository(context);
var service = new UpdateService(repository);
service.UpdateLeagueTeamPlayers(oeEntities);