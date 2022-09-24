using System.Text.Json.Serialization;

namespace CombatCompanion.SportRadar.Models;

public class Season
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("start_date")]
    public string StartDate { get; set; }

    [JsonPropertyName("end_date")]
    public string EndDate { get; set; }

    [JsonPropertyName("year")]
    public string Year { get; set; }

    [JsonPropertyName("competition_id")]
    public string CompetitionId { get; set; }
}