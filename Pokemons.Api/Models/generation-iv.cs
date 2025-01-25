using System.Text.Json.Serialization;

namespace Pokemons.Api.Models;

public class generation_iv
{
    [JsonPropertyName("diamond-pearl")]
    public generation_iv_diamond_pearl diamond_pearl { get; set; }

    [JsonPropertyName("heartgold-soulsilver")]
    public generation_iv_heartgold_soulsilver heartgold_soulsilver { get; set; }
    public generation_iv_platinum platinum { get; set; }
}