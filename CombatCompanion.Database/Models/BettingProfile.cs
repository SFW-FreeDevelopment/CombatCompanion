using System.ComponentModel.DataAnnotations;

namespace CombatCompanion.Database.Models;

public class BettingProfile : BaseResource
{
    [Required] public string EventId { get; set; }
    [Required] public List<Bet> Bets { get; set; } = new();
}

public class Bet
{
    public ulong DiscordOwnerId { get; set; }
    public long Amount { get; set; }
    public int Round { get; set; }
    public string FighterId { get; set; }
}