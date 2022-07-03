using System.ComponentModel.DataAnnotations;
using System.Text;
using CombatCompanion.Database.Enums;

namespace CombatCompanion.Database.Models;

public class Event : BaseResource
{
    [Required] public List<MatchUp> MatchUps { get; set; } = new();
    [Required] public EventType EventType { get; set; } = EventType.Exhibition;
    [Required] public EventSubType EventSubType { get; set; } = EventSubType.Gaming;
    [Required] public TeamSize TeamSize { get; set; } = TeamSize.Singles;
    [Required] public EventStatus EventStatus { get; set; } = EventStatus.Created;
    public FightLeague? FightLeague { get; set; }
}

public abstract class MatchUp
{
    public string Title { get; set; }
    public int Round { get; set; }
}

public class SinglesMatchUp : MatchUp
{
    public Fighter FighterOne { get; set; }
    public Fighter FighterTwo { get; set; }

    public SinglesMatchUp(Fighter fighterOne, Fighter fighterTwo)
    {
        FighterOne = fighterOne;
        FighterTwo = fighterTwo;
        Title = $"{FighterOne.Name} vs {FighterTwo.Name}";
    }
}

public class TeamsMatchUp : MatchUp
{
    public Team TeamOne { get; set; }
    public Team TeamTwo { get; set; }

    public TeamsMatchUp(Team teamOne, Team teamTwo)
    {
        TeamOne = teamOne;
        TeamTwo = teamTwo;
        if (string.IsNullOrWhiteSpace(TeamOne?.Name) || string.IsNullOrWhiteSpace(TeamTwo?.Name))
        {
            if (TeamOne?.Fighters == null || TeamTwo?.Fighters == null) return;
            var sb = new StringBuilder();
            for (var i = 0; i < TeamOne.Fighters.Count; i++)
            {
                if (i == 0)
                {
                    sb.Append(TeamOne.Fighters[i].Name);
                }
                else
                {
                    sb.Append($"/{TeamOne.Fighters[i].Name}");
                }
            }
            sb.Append(" vs ");
            for (var i = 0; i < TeamTwo.Fighters.Count; i++)
            {
                if (i == 0)
                {
                    sb.Append(TeamTwo.Fighters[i].Name);
                }
                else
                {
                    sb.Append($"/{TeamTwo.Fighters[i].Name}");
                }
            }
        }
        else
        {
            Title = $"{TeamOne.Name} vs {TeamTwo.Name}";
        }
    }
}

public class Team
{
    public List<Fighter> Fighters { get; set; } = new();
    public string Name { get; set; }
}