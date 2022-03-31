using LeagueData.Data.Entities;
using LeagueData.Data.Repositories;
using LeagueData.Entities;

namespace LeagueData;

public class UpdateService
{
    private readonly LeagueRepository _repository;
    public UpdateService(LeagueRepository repository)
    {
        _repository = repository;
    }

    public void UpdateLeagueTeamPlayers(List<OeEntity> oeEntities)
    {
        var counter = 0;
        foreach (var entity in oeEntities)
        {
            counter++;
            var ltp = _repository.GetLeagueTeamPlayer(entity.PlayerId, entity.TeamId);
            if (ltp is not null)
            {
                Console.WriteLine("Found Existing LTP");
                continue;
            }

            ltp = _repository.GetLeagueTeamPlayerByNames(entity.PlayerName, entity.TeamName);
            if (ltp is null)
            {
                ltp = CreateLeagueTeamPlayer(entity);
                _repository.AddLeagueTeamPlayer(ltp);
                _repository.Save();
                Console.WriteLine("Saved New League Team Player");
            }
            else
            {
                if (!ltp.LeaguePlayerId.StartsWith("oe") || ltp.LeaguePlayerId != entity.PlayerId)
                {
                    Console.WriteLine($"Received Invalid PlayerId: {ltp.LeaguePlayerId}");
                    UpdatePlayer(entity, ltp);
                }

                if (!ltp.LeagueTeamId.StartsWith("oe") || ltp.LeagueTeamId != entity.TeamId)
                {
                    Console.WriteLine($"Received Invalid TeamId: {ltp.LeagueTeamId}");
                    UpdateTeam(entity, ltp);
                }
                
                _repository.Save();
                Console.WriteLine("Saved");
            }
        }
    }

    private void UpdatePlayer(OeEntity entity, LeagueTeamPlayer ltp)
    {
        // We have to do multipe queries because we changed how the entities are related
        var player = _repository.GetLeaguePlayer(entity.PlayerId);
        if (player is null)
        {
            Console.WriteLine($"Creating new player: {entity.PlayerId}");
            player = CreateLeaguePlayer(entity);
            _repository.AddPlayer(player);
            _repository.Save();
        }
        ltp.LeaguePlayerId = entity.PlayerId;
        Console.WriteLine($"Updated with new Player ID: {entity.PlayerId}");
    }

    private void UpdateTeam(OeEntity entity, LeagueTeamPlayer ltp)
    {
        var team = _repository.GetLeagueTeam(entity.TeamId);
        if (team is null)
        {
            Console.WriteLine($"Creating new team: {entity.TeamId}");
            team = CreateLeagueTeam(entity);
            _repository.AddTeam(team);
            _repository.Save();
        }

        ltp.LeagueTeam = team;
        ltp.LeagueTeamId = entity.TeamId;
        Console.WriteLine($"Updated with new team ID: {entity.TeamId}");
    }

    private LeaguePlayer CreateLeaguePlayer(OeEntity entity)
    {
        return new LeaguePlayer
        {
            LeaguePlayerId = entity.PlayerId,
            PlayerName = entity.PlayerName
        };
    }

    private LeagueTeam CreateLeagueTeam(OeEntity entity)
    {
        return new LeagueTeam
        {
            LeagueTeamId = entity.TeamId,
            TeamName = entity.TeamName
        };
    }

    private LeagueTeamPlayer CreateLeagueTeamPlayer(OeEntity entity)
    {
        var ltp =  new LeagueTeamPlayer
        {
            LeaguePlayerId = entity.PlayerId,
            LeagueTeamId = entity.TeamId
        };
        
        UpdatePlayer(entity, ltp);
        UpdateTeam(entity, ltp);
        return ltp;
    }
}