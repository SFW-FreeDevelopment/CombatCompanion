using CombatCompanion.Database.Enums;

namespace CombatCompanion.Database.Models;

public class Events
{
    public EventType EventType { get; set; }
    public TeamSize TeamSize { get; set; } = TeamSize.Singles;
}