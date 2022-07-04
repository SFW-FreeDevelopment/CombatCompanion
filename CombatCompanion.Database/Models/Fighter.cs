using System.ComponentModel.DataAnnotations;

namespace CombatCompanion.Database.Models;

public class Fighter : BaseResource
{
    [Required] public string Name { get; set; }
    [Required] public List<string> WeightClasses { get; set; } = new();
    [Required] public int Wins { get; set; }
    [Required] public int Losses { get; set; }
    [Required] public int Draws { get; set; }
    [Required] public bool IsFantasy { get; set; }
}