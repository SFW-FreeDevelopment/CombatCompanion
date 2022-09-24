using System.Text.Json.Serialization;

namespace CombatCompanion.SportRadar.Models;

public class Root<T>
{
    [JsonPropertyName("generated_at")]
    public DateTime GeneratedAt { get; set; }
    
    public List<T> Collection { get; set; }
}