using System.Linq;
using LeagueData.Data.Contexts;
using LeagueData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using OddsGenerationService.Data.Constants;

namespace LeagueData.Data.Repositories;

public class LeagueRepository
{
    private readonly LeagueDbContext _context;
    public LeagueRepository(LeagueDbContext context)
    {
        _context = context;
    }

    public LeagueTeamPlayer? GetLeagueTeamPlayer(string leaguePlayerId, string leagueTeamId)
    {
        return _context.LeagueTeamPlayers.FirstOrDefault(
            x => x.LeaguePlayerId == leaguePlayerId &&
                 x.LeagueTeamId == leagueTeamId);
    }

    public LeagueTeamPlayer? GetLeagueTeamPlayerByNames(string playerName, string teamName)
    {
        return _context.LeagueTeamPlayers
            .FirstOrDefault(
                x => x.PlayerName == playerName &&
                     x.TeamName == teamName
            );
    }

    public LeaguePlayer? GetLeaguePlayer(string leaguePlayerId)
    {
        return _context.LeaguePlayers.FirstOrDefault(x => x.LeaguePlayerId == leaguePlayerId);
    }

    public LeagueTeam? GetLeagueTeam(string leagueTeamId)
    {
        return _context.LeagueTeams.FirstOrDefault(x => x.LeagueTeamId == leagueTeamId);
    }

    public void AddPlayer(LeaguePlayer player)
    {
        _context.LeaguePlayers.Add(player);
    }

    public void AddTeam(LeagueTeam team)
    {
        _context.LeagueTeams.Add(team);
    }

    public void AddLeagueTeamPlayer(LeagueTeamPlayer leagueTeamPlayer)
    {
        _context.LeagueTeamPlayers.Add(leagueTeamPlayer);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}