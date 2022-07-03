using System.ComponentModel.DataAnnotations;
using CombatCompanion.Database.Enums;

namespace CombatCompanion.Database.Models;

public class Fighter : BaseResource
{
    [Required] public string Name { get; set; }
    [Required] public List<WeightClass> WeightClasses { get; set; } = new();
}