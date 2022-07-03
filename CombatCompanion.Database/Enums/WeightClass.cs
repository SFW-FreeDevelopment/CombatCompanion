using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace CombatCompanion.Database.Enums;

[JsonConverter(typeof(StringEnumConverter))]
public enum WeightClass
{
    Strawweight,
    Flyweight,
    Batamweight,
    Featherweight,
    Lightweight,
    SuperLightweight,
    Welterweight,
    SuperWelterweight,
    Middleweight,
    SuperMiddleweight,
    LightHeavyweight,
    Cruiserweight,
    Heavyweight,
    SuperHeavyweight
}