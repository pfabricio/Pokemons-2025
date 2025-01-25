using System.Text.Json.Serialization;

namespace Pokemons.Api.Models;

public class sprite_versions
{
    [JsonPropertyName("generation-i")]
    public generation_i generation_i { get; set; }

    [JsonPropertyName("generation-ii")]
    public generation_ii generation_ii { get; set; }

    [JsonPropertyName("generation-iii")]
    public generation_iii generation_iii { get; set; }

    [JsonPropertyName("generation-iv")]
    public generation_iv generation_iv { get; set; }

    [JsonPropertyName("generation-v")]
    public generation_v generation_v { get; set; }

    [JsonPropertyName("generation-vi")]
    public generation_vi generation_vi { get; set; }

    [JsonPropertyName("generation-vii")]
    public generation_vii generation_vii { get; set; }

    [JsonPropertyName("generation-viii")]
    public generation_viii generation_viii { get; set; }
}